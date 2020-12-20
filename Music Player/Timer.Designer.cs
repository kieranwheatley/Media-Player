namespace Music_Player
{
    partial class Timer
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
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblMainTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(-1, -1);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 55);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Click += new System.EventHandler(this.lblTimer_Click);
            // 
            // lblMainTimer
            // 
            this.lblMainTimer.AutoSize = true;
            this.lblMainTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTimer.Location = new System.Drawing.Point(-8, -1);
            this.lblMainTimer.Name = "lblMainTimer";
            this.lblMainTimer.Size = new System.Drawing.Size(284, 108);
            this.lblMainTimer.TabIndex = 1;
            this.lblMainTimer.Text = "60:00";
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(253, 99);
            this.Controls.Add(this.lblMainTimer);
            this.Controls.Add(this.lblTimer);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Timer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Timer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Timer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTimer;
        public System.Windows.Forms.Label lblMainTimer;
    }
}