namespace S3
{
    partial class MainForm
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
            this.Player1Name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Player1Score = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Player1Character = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Player1Sponsor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Player2Score = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.Player2Character = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Player2Sponsor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Player2Name = new System.Windows.Forms.TextBox();
            this.SendUpdateButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CasterTextbox = new System.Windows.Forms.TextBox();
            this.StreamerTextbox = new System.Windows.Forms.TextBox();
            this.StartServer = new System.Windows.Forms.Button();
            this.UrlLinkLabel = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Score)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Score)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Player1Name
            // 
            this.Player1Name.Location = new System.Drawing.Point(6, 32);
            this.Player1Name.Name = "Player1Name";
            this.Player1Name.Size = new System.Drawing.Size(100, 20);
            this.Player1Name.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Player1Score);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Player1Character);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Player1Sponsor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Player1Name);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Score";
            // 
            // Player1Score
            // 
            this.Player1Score.Location = new System.Drawing.Point(133, 71);
            this.Player1Score.Name = "Player1Score";
            this.Player1Score.Size = new System.Drawing.Size(43, 20);
            this.Player1Score.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Character";
            // 
            // Player1Character
            // 
            this.Player1Character.FormattingEnabled = true;
            this.Player1Character.Location = new System.Drawing.Point(6, 71);
            this.Player1Character.Name = "Player1Character";
            this.Player1Character.Size = new System.Drawing.Size(121, 21);
            this.Player1Character.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sponsor";
            // 
            // Player1Sponsor
            // 
            this.Player1Sponsor.FormattingEnabled = true;
            this.Player1Sponsor.Location = new System.Drawing.Point(118, 31);
            this.Player1Sponsor.Name = "Player1Sponsor";
            this.Player1Sponsor.Size = new System.Drawing.Size(121, 21);
            this.Player1Sponsor.TabIndex = 2;
            this.Player1Sponsor.SelectedIndexChanged += new System.EventHandler(this.Player1Sponsor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Player2Score);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Player2Character);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Player2Sponsor);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Player2Name);
            this.groupBox2.Location = new System.Drawing.Point(263, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 113);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Score";
            // 
            // Player2Score
            // 
            this.Player2Score.Location = new System.Drawing.Point(133, 71);
            this.Player2Score.Name = "Player2Score";
            this.Player2Score.Size = new System.Drawing.Size(43, 20);
            this.Player2Score.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Character";
            // 
            // Player2Character
            // 
            this.Player2Character.FormattingEnabled = true;
            this.Player2Character.Location = new System.Drawing.Point(6, 71);
            this.Player2Character.Name = "Player2Character";
            this.Player2Character.Size = new System.Drawing.Size(121, 21);
            this.Player2Character.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sponsor";
            // 
            // Player2Sponsor
            // 
            this.Player2Sponsor.FormattingEnabled = true;
            this.Player2Sponsor.Location = new System.Drawing.Point(118, 31);
            this.Player2Sponsor.Name = "Player2Sponsor";
            this.Player2Sponsor.Size = new System.Drawing.Size(121, 21);
            this.Player2Sponsor.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Name";
            // 
            // Player2Name
            // 
            this.Player2Name.Location = new System.Drawing.Point(6, 32);
            this.Player2Name.Name = "Player2Name";
            this.Player2Name.Size = new System.Drawing.Size(100, 20);
            this.Player2Name.TabIndex = 0;
            // 
            // SendUpdateButton
            // 
            this.SendUpdateButton.Location = new System.Drawing.Point(251, 11);
            this.SendUpdateButton.Name = "SendUpdateButton";
            this.SendUpdateButton.Size = new System.Drawing.Size(106, 23);
            this.SendUpdateButton.TabIndex = 8;
            this.SendUpdateButton.Text = "Send Update";
            this.SendUpdateButton.UseVisualStyleBackColor = true;
            this.SendUpdateButton.Click += new System.EventHandler(this.SendUpdateButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.StartServer);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.CasterTextbox);
            this.groupBox4.Controls.Add(this.SendUpdateButton);
            this.groupBox4.Controls.Add(this.StreamerTextbox);
            this.groupBox4.Location = new System.Drawing.Point(72, 131);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(378, 71);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Misc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Streamer";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(115, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Casters";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // CasterTextbox
            // 
            this.CasterTextbox.Location = new System.Drawing.Point(118, 35);
            this.CasterTextbox.Name = "CasterTextbox";
            this.CasterTextbox.Size = new System.Drawing.Size(100, 20);
            this.CasterTextbox.TabIndex = 10;
            this.CasterTextbox.TextChanged += new System.EventHandler(this.CasterTextbox_TextChanged);
            // 
            // StreamerTextbox
            // 
            this.StreamerTextbox.Location = new System.Drawing.Point(6, 35);
            this.StreamerTextbox.Name = "StreamerTextbox";
            this.StreamerTextbox.Size = new System.Drawing.Size(100, 20);
            this.StreamerTextbox.TabIndex = 9;
            // 
            // StartServer
            // 
            this.StartServer.Location = new System.Drawing.Point(268, 40);
            this.StartServer.Name = "StartServer";
            this.StartServer.Size = new System.Drawing.Size(75, 23);
            this.StartServer.TabIndex = 16;
            this.StartServer.Text = "Start Server";
            this.StartServer.UseVisualStyleBackColor = true;
            this.StartServer.Click += new System.EventHandler(this.StartServer_Click);
            // 
            // UrlLinkLabel
            // 
            this.UrlLinkLabel.AutoSize = true;
            this.UrlLinkLabel.Location = new System.Drawing.Point(304, 313);
            this.UrlLinkLabel.Name = "UrlLinkLabel";
            this.UrlLinkLabel.Size = new System.Drawing.Size(0, 13);
            this.UrlLinkLabel.TabIndex = 17;
            this.UrlLinkLabel.Click += new System.EventHandler(this.UrlLinkLabel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 211);
            this.Controls.Add(this.UrlLinkLabel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Melee Scoreboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Score)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Score)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Player1Name;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Player1Score;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Player1Character;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Player1Sponsor;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Player2Score;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Player2Character;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Player2Sponsor;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Player2Name;
        private System.Windows.Forms.Button SendUpdateButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox CasterTextbox;
        private System.Windows.Forms.TextBox StreamerTextbox;
        private System.Windows.Forms.Button StartServer;
        private System.Windows.Forms.LinkLabel UrlLinkLabel;
    }
}

