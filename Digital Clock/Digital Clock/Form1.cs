using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class Clock : Form
    {
        Timer t = new Timer();
        public Clock()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }
        private void t_Tick(object sender, EventArgs e)
        {
            int hours = DateTime.Now.Hour;
            int minutes = DateTime.Now.Minute;
            int seconds = DateTime.Now.Second;
            string Time = "";

            if (hours < 10)
            {
                Time += "0" + hours;
            }
            else
            {
                Time += hours;
            }
            Time += ":";
            if (minutes < 10)
            {
                Time += "0" + minutes;
            }
            else
            {
                Time += minutes;
            }
            Time += ":";
            if (seconds < 10)
            {
                Time += "0" + seconds;
            }
            else
            {
                Time += seconds;
            }

            label1.Text = Time;
        }
    }
}
