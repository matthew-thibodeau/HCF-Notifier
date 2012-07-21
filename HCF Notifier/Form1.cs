using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace HCF_Notifier
{
    public partial class Form1 : Form
    {
        #region Properties and Variables
        public int Minutes
        {
            get
            {
                return (int)minutes.Value;
            }
            set
            {
                minutes.Value = value;
            }
        }
        public int Seconds
        {
            get
            {
                return (int)seconds.Value;
            }
            set
            {
                seconds.Value = value;
            }
        }
        Timer timer = null;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            players.Items.Add(new ListViewItem(player.Text));
            player.Text = "";
        }

        private void removePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (players.SelectedItems.Count > 0)
                players.SelectedItems[0].Remove();
        }

        private void seconds_ValueChanged(object sender, EventArgs e)
        {
            if (seconds.Value >= 60)
            {
                minutes.Value += seconds.Value / 60;
                seconds.Value = seconds.Value % 60;
            }
        }

        bool ticking = false;
        private void start_Click(object sender, EventArgs e)
        {
            if (!ticking)
            {
                if (players.Items.Count == 0)
                    return;
                ticking = true;
                timer.Interval = (Minutes * 60 + Seconds) * 1000;
                timer.Tick += new EventHandler(timer_Tick);
                timer.Start();
                start.Text = "Stop Checking";
            }
            else if (ticking)
            {
                ticking = false;
                timer.Stop();
                start.Text = "Start Checking";
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            List<string> onlinePlayers = new List<string>();
            foreach (ListViewItem item in players.Items)
            {
                string name = item.Text;
                bool on = new WebClient().DownloadString("http://www.hcfactions.net/ajax/whosonline.php").Contains(name);
                if (on)
                {
                    onlinePlayers.Add(name);
                }
            }
            string notifyPlayers = "";
            foreach (string str in onlinePlayers)
                notifyPlayers += str + ", ";
            if (notifyPlayers.Length > 0)
            {
                notifyPlayers = notifyPlayers.Substring(0, notifyPlayers.Length - 2);
                notifyIcon1.ShowBalloonTip(4500, "Player is online!", "The players (" + notifyPlayers + ") are online.", ToolTipIcon.Warning);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new Timer();
        }

        private void player_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                add_Click(this, e);
        }
    }
}
