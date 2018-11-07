﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balles
{
    public partial class Form1 : Form
    {
        Timer tm = new Timer();
        Int32 vitesseX = 5;
        Int32 vitesseY = 5;
        public Form1()
        {
            InitializeComponent();

            tm.Interval = 50;
            tm.Tick += bouger; ;
            tm.Enabled = true;
        }

        private void bouger(Object sender, EventArgs e)
        {
            if (pbBalle.Left < 0) { vitesseX = -vitesseX; }
            if (pbBalle.Left > this.Width - pbBalle.Width - 15) { vitesseX = -vitesseX; }
            if (pbBalle.Top < 0) { vitesseY = -vitesseY; }
            if (pbBalle.Top > this.Height - pbBalle.Height - 38) { vitesseY = -vitesseY; }
            pbBalle.Left = pbBalle.Left + vitesseX;
            pbBalle.Top = pbBalle.Top + vitesseY;
        }
    }
}
