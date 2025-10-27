using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player2
{
    public partial class Player2 : Form
    {
        private object openFileDialog;

        public Player2()
        {
            InitializeComponent();
        }

        private void Player2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            media.settings.volume = 0;
        }

        private void playerbutton_Click(object sender, EventArgs e)
        {
            media.Ctlcontrols.play();
        }

        private void openbutton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            media.URL = openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            media.settings.volume = +1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            media.settings.volume = +1;

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            media.Ctlcontrols.stop();
        }

        private void aushebutton_Click(object sender, EventArgs e)
        {
            media.Ctlcontrols.pause();
        }

        private void unmutebutton_Click(object sender, EventArgs e)
        {
            media.settings.volume = 50;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
