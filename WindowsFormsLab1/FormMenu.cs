using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLab1
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            startLevel1();
        }

        private void boxSound_CheckedChanged(object sender, EventArgs e)
        {
            if (boxSound.Checked)
            {
                Sound.soundOn();
                boxSound.Text = "Звук выключен";
                Sound.playKey();
            }

            else
            {
                Sound.soundOff();
                boxSound.Text = "Звук включен";
            }
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startLevel1()
        {
            FormLevel1 level1 = new FormLevel1();
            level1.ShowDialog();

        }
    }
}
