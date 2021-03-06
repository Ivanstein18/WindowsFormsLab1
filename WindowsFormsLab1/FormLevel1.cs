﻿using System;
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
    public partial class FormLevel1 : Form
    {
        public FormLevel1()
        {
            InitializeComponent();
        }

        private void startGame()
        {
            Point point = labelStart.Location;
            point.Offset(labelStart.Width / 2, labelStart.Height / 2);
            Cursor.Position = PointToScreen(point);
            Sound.playStart();
        }

        private void finishGame()
        {
            Sound.playFail();
            DialogResult dr = MessageBox.Show("Вы проиграли! Еще раз?", "Сщщбщение", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                startGame();
            else
                DialogResult = DialogResult.Abort;
        }

        private void FormLevel1_Shown(object sender, EventArgs e)
        {
            startGame();
        }

        private void labelFinish_MouseEnter(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void FormLevel1_MouseEnter(object sender, EventArgs e)
        {
            finishGame();
        }
    }
}
