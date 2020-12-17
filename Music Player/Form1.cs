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
        }
            private void lstSongs_SelectedIndexChanged(object sender, EventArgs e)
            {
                //Play music
                mediaPlayer.URL = path[lstSongs.SelectedIndex];
            }

            private void musicPlayerApp_Load(object sender, EventArgs e)
            {
            
            }

            private void picCloseButton_Click(object sender, EventArgs e)
            {
                //Close the app
                this.Close();
            }
        }
    }

