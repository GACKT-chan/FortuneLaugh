using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortuneLaugh
{
    class Picture:PictureBox
    {
        private TextBox textBox;
      
        public Picture(TextBox textBox): base()
        {
            this.textBox = textBox;
        }

        public void PictureMouseDown(int x,int y)
        {
            this.Left = x;
            this.Top = y;
            this.textBox.Text = "X = " + x + " Y = " + y;
        }

        public void PictureMouseMove(int x, int y,Size formSize)
        {
            //if(formSize)
            this.Left = x;
            this.Top = y;
            this.textBox.Text = "X = " + x + " Y = " + y;
        }


    }
}
