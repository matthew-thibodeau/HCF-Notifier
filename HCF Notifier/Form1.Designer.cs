namespace HCF_Notifier
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.players = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // players
            // 
            this.players.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.players.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.players.GridLines = true;
            this.players.Location = new System.Drawing.Point(0, 259);
            this.players.Name = "players";
            this.players.Size = new System.Drawing.Size(518, 108);
            this.players.TabIndex = 0;
            this.players.UseCompatibleStateImageBehavior = false;
            this.players.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Players";
            this.columnHeader1.Width = 95;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 20);
            this.textBox1.TabIndex = 1;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(331, 10);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(175, 23);
            this.add.TabIndex = 2;
            this.add.Text = "Add Player To List";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 367);
            this.Controls.Add(this.add);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.players);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "HC Factions Notifier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView players;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button add;
    }
}

