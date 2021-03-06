﻿using System;
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
        private Bitmap bitmap;
        private Bitmap originPic;
        private string name;
      
        public Picture(): base()
        {

        }

        public Picture(TextBox textBox): base()
        {
            this.textBox = textBox;
        }

        public void PictureMouseDown(int x,int y)
        {
            this.Left = x;
            this.Top = y;
            this.textBox.Text = this.name + "\t:X = " + x + " Y = " + y;
            this.bitmap = new Bitmap(this.Width, this.Height);
            this.bitmap.MakeTransparent();
            this.Image = this.bitmap;
        }

        public void PictureMouseMove(int x, int y,Size clientSize)
        {
            if (x > 0 && x + this.Width < clientSize.Width)
            {
                this.Left = x;
            }
            if (y > 0 && y + this.Height < clientSize.Height)
            {
                this.Top = y;
            }
            this.textBox.Text = this.name + "\t:X = " + x + " Y = " + y;
        }

        public void SetTextBox(TextBox t,string name)
        {
            this.textBox = t;
            this.name = name;
        }
        public void SetOriginPic()
        {
            this.originPic = new Bitmap(this.Image);
        }

        public void VisualizePicture()
        {
            this.BringToFront();
            this.Image = this.originPic;
        }

    }
}
