namespace Music_Player
{
    partial class musicPlayerApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musicPlayerApp));
            this.lstSongs = new System.Windows.Forms.ListBox();
            this.btnSelectSong = new System.Windows.Forms.Button();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblFooter = new System.Windows.Forms.Label();
            this.btnStartRoom = new System.Windows.Forms.Button();
            this.cmbMinutes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSeconds = new System.Windows.Forms.ComboBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.lblTeamTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lstSongs
            // 
            this.lstSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSongs.FormattingEnabled = true;
            this.lstSongs.ItemHeight = 16;
            this.lstSongs.Location = new System.Drawing.Point(647, 12);
            this.lstSongs.Name = "lstSongs";
            this.lstSongs.Size = new System.Drawing.Size(267, 68);
            this.lstSongs.TabIndex = 1;
            this.lstSongs.SelectedIndexChanged += new System.EventHandler(this.lstSongs_SelectedIndexChanged);
            // 
            // btnSelectSong
            // 
            this.btnSelectSong.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSelectSong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSelectSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectSong.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnSelectSong.Location = new System.Drawing.Point(647, 86);
            this.btnSelectSong.Name = "btnSelectSong";
            this.btnSelectSong.Size = new System.Drawing.Size(267, 43);
            this.btnSelectSong.TabIndex = 2;
            this.btnSelectSong.Text = "Add Backing Track";
            this.btnSelectSong.UseVisualStyleBackColor = false;
            this.btnSelectSong.Click += new System.EventHandler(this.btnSelectSong_Click);
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(9, 12);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(632, 485);
            this.mediaPlayer.TabIndex = 3;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFooter.Location = new System.Drawing.Point(657, 539);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(263, 13);
            this.lblFooter.TabIndex = 4;
            this.lblFooter.Text = "Developed by: Kieran W | For use of Escape Plymouth";
            // 
            // btnStartRoom
            // 
            this.btnStartRoom.Location = new System.Drawing.Point(647, 222);
            this.btnStartRoom.Name = "btnStartRoom";
            this.btnStartRoom.Size = new System.Drawing.Size(267, 43);
            this.btnStartRoom.TabIndex = 5;
            this.btnStartRoom.Text = "Start Game";
            this.btnStartRoom.UseVisualStyleBackColor = true;
            this.btnStartRoom.Click += new System.EventHandler(this.btnStartRoom_Click);
            // 
            // cmbMinutes
            // 
            this.cmbMinutes.FormattingEnabled = true;
            this.cmbMinutes.Location = new System.Drawing.Point(744, 133);
            this.cmbMinutes.Name = "cmbMinutes";
            this.cmbMinutes.Size = new System.Drawing.Size(165, 21);
            this.cmbMinutes.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(656, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Minutes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(647, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seconds:";
            // 
            // cmbSeconds
            // 
            this.cmbSeconds.FormattingEnabled = true;
            this.cmbSeconds.Location = new System.Drawing.Point(744, 161);
            this.cmbSeconds.Name = "cmbSeconds";
            this.cmbSeconds.Size = new System.Drawing.Size(121, 21);
            this.cmbSeconds.TabIndex = 9;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(647, 367);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(267, 44);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset Game";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(647, 316);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(266, 45);
            this.btnPause.TabIndex = 11;
            this.btnPause.Text = "Pause Game";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnResume
            // 
            this.btnResume.Enabled = false;
            this.btnResume.Location = new System.Drawing.Point(647, 271);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(267, 39);
            this.btnResume.TabIndex = 12;
            this.btnResume.Text = "Resume Game";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // lblTeamTime
            // 
            this.lblTeamTime.AutoSize = true;
            this.lblTeamTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamTime.Location = new System.Drawing.Point(644, 436);
            this.lblTeamTime.Name = "lblTeamTime";
            this.lblTeamTime.Size = new System.Drawing.Size(0, 24);
            this.lblTeamTime.TabIndex = 13;
            // 
            // musicPlayerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 552);
            this.Controls.Add(this.lblTeamTime);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cmbSeconds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMinutes);
            this.Controls.Add(this.btnStartRoom);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.btnSelectSong);
            this.Controls.Add(this.lstSongs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "musicPlayerApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escape Plymouth - Game Controller";
            this.Load += new System.EventHandler(this.musicPlayerApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstSongs;
        private System.Windows.Forms.Button btnSelectSong;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Button btnStartRoom;
        private System.Windows.Forms.ComboBox cmbMinutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSeconds;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnResume;
        public System.Windows.Forms.Label lblTeamTime;
    }
}

