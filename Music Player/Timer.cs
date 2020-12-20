using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class Timer : Form
    {

        public Timer()
        {
            InitializeComponent();
        }

        private void Timer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }
        public void hideBar()
        {
            this.ControlBox = false;
            this.Text = String.Empty;
            Location = Screen.AllScreens[1].WorkingArea.Location;

        }

    }
}
