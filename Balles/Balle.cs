using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balles
{
    class Balle : PictureBox
    {
        Timer tm = new Timer();
        

        public Balle() : base()
        {
            tm.Interval = 50;
            tm.Tick += bouger;
            tm.Enabled = true;
        }

        public Balle(int vitesseX, int vitesseY) : base()
        {
            this.vitesseX = vitesseX;
            this.vitesseY = vitesseY;
            tm.Interval = 50;
            tm.Tick += bouger;
            tm.Enabled = true;
            
        }

        public Int32 vitesseX { get; set; }
        public Int32 vitesseY { get; set; }

        private void bouger(Object sender, EventArgs e)
        {
            
            if (this.Left < 0) { vitesseX = -this.vitesseX; }
            if (this.Left > FindForm().Width - Width - 15) { vitesseX = -vitesseX; }
            if (this.Top < 0) { vitesseY = -vitesseY; }
            if (this.Top > FindForm().Height - Height - 38) { vitesseY = -vitesseY; }
            this.Left = this.Left + vitesseX;
            this.Top = this.Top + vitesseY;

        }
    }
}
