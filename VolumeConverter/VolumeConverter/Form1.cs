using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolumeConverter
{
    public partial class volumecon : Form
    {
        public volumecon()
        {
            InitializeComponent();
            literbox.Enabled = false;
        }
        private void convertButton_Click(object sender, EventArgs e)
        {
            float cl;
            float liter;
            cl = Convert.ToInt32(clBox.Text);
            liter = cl / 100;
            literbox.Text = (liter.ToString());
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clBox.Text = "";
            literbox.Text = "";
        }
    }
}
