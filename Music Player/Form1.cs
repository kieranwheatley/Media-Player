using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class musicPlayerApp : Form
    {
        public musicPlayerApp()
        {
            InitializeComponent();
        }
        //Global Variables
        string[] path, file;
        Timer timerForm = new Timer();
        public int totalSeconds;





        //Select z
        OpenFileDialog openFile = new OpenFileDialog();


        private void btnSelectSong_Click(object sender, EventArgs e)
        {
            //Multiple Files
            openFile.Multiselect = true;

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Save song name to file array
                file = openFile.SafeFileNames;
                //Save song path to path array
                path = openFile.FileNames;

                //Display music titles in list box
                for (int i = 0; i < file.Length; i++)
                {
                    //Gets each item of file array and adds to list box
                    lstSongs.Items.Add(file[i]);
                }
            }
            lstSongs.SelectedIndex = 0;
        }
        private void lstSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Play music
            mediaPlayer.URL = path[lstSongs.SelectedIndex];
            System.Threading.Thread.Sleep(500);
            mediaPlayer.Ctlcontrols.stop();
        }

        public void musicPlayerApp_Load(object sender, EventArgs e)
        {
            timerForm.SetBounds(0, 0, 269, 138);
            timerForm.Show();
            timerForm.Location = new Point(0, 0);
            timerForm.hideBar();

            for (int seconds = 0; seconds < 61; seconds++)
            {
                this.cmbMinutes.Items.Add(seconds.ToString());
                this.cmbSeconds.Items.Add(seconds.ToString());
            }
            cmbMinutes.SelectedIndex = 60;
            cmbSeconds.SelectedIndex = 0;
            timerForm.Visible = false;
        }
        private void btnStartRoom_Click(object sender, EventArgs e)
        {
            this.btnStartRoom.Enabled = false;
            this.btnReset.Enabled = true;
            this.btnPause.Enabled = true;

            int minutes = int.Parse(this.cmbMinutes.SelectedIndex.ToString());
            int seconds = int.Parse(this.cmbSeconds.SelectedIndex.ToString());

            totalSeconds = (minutes * 60) + seconds;

            
            mediaPlayer.Ctlcontrols.play();
            timerForm.Visible = true;
            this.timer.Enabled = true;
            mediaPlayer.settings.volume = 100;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.btnReset.Enabled = false;
            this.btnStartRoom.Enabled = true;
            this.btnPause.Enabled = false;
            totalSeconds = 0;
            timerForm.lblMainTimer.Text = "60:00";
            this.lblTeamTime.Text = "";
            mediaPlayer.Ctlcontrols.stop();
            timerForm.Visible = false;
            this.btnReset.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds--;
                int minutes = totalSeconds / 60;
                int seconds = totalSeconds - (minutes * 60);
                timerForm.lblMainTimer.Text = (minutes.ToString() + ":" + seconds.ToString());
                this.lblTeamTime.Text = ("Team time: " + minutes.ToString() + ":" + seconds.ToString());
            }
            else
            {
                this.timer.Stop();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            this.btnPause.Enabled = false;
            this.btnReset.Enabled = true;
            this.btnStartRoom.Enabled = false;
            this.btnResume.Enabled = true;
            mediaPlayer.Ctlcontrols.pause();
            timer.Stop();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            btnResume.Enabled = false;
            this.btnReset.Enabled = true;
            this.btnPause.Enabled = true;
            this.btnStartRoom.Enabled = false;
            mediaPlayer.Ctlcontrols.play();
            timer.Start();
        }

        private void picCloseButton_Click(object sender, EventArgs e)
            {
                //Close the app
                this.Close();
            }
        }

    }

