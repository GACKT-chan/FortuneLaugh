using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortuneLaugh
{
    public partial class Form1 : Form
    {
        private bool IsDragging;
        private int DifferenceXFromItem;
        private int DifferenceYFromItem;
        private Point CursorPointOnForm;

        private Picture LeftEyePic, RightEyePic, NosePic, MousePic;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LeftEyePic = new Picture(LeftEyeLocation);
            RightEyePic = new Picture(RightEyeLocation);
            NosePic = new Picture(NoseLocation);
            MousePic = new Picture(MouseLocation);

        }

        private void MouseMoveOnForm(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.CursorPointOnForm = this.PointToClient(Cursor.Position);
            CursorLocation.Text = "X = " + this.CursorPointOnForm.X + " Y = " + this.CursorPointOnForm.Y;
        }

        private void PartsMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //this.DifferenceXFromItem = this.CursorPointOnForm.X - LeftEye.Left;
            //this.DifferenceYFromItem = this.CursorPointOnForm.Y - LeftEye.Top;
            //LeftEye.Left = Cursor.Position.X + this.DifferenceXFromItem;
            //LeftEye.Top = Cursor.Position.Y + this.DifferenceYFromItem;

            if (sender is Picture picture && e.Button == MouseButtons.Left)
            {
                this.CursorPointOnForm = this.PointToClient(Cursor.Position);
                this.DifferenceXFromItem = this.CursorPointOnForm.X - picture.Left;
                this.DifferenceYFromItem = this.CursorPointOnForm.Y - picture.Top;
                picture.PictureMouseDown(Cursor.Position.X + this.DifferenceXFromItem, Cursor.Position.Y + this.DifferenceYFromItem);
                System.Windows.Forms.Cursor.Hide();
                this.IsDragging = true;
            }
        }

        private void PartsMouseMove(object sender, MouseEventArgs e)
        {
            if (sender is Picture picture && e.Button == MouseButtons.Left && IsDragging)
            {
                this.CursorPointOnForm = this.PointToClient(Cursor.Position);
                //LeftEyeLocation.Text = "X = " + LeftEye.Top + " Y = " + this.CursorPointOnForm.Y;
                //LeftEye.Left = CursorPointOnForm.X - DifferenceXFromItem;
                //LeftEye.Top = CursorPointOnForm.Y - DifferenceYFromItem;
                picture.PictureMouseMove(CursorPointOnForm.X - DifferenceXFromItem, CursorPointOnForm.Y - DifferenceYFromItem, this.Size);
            }
        }

        private void PartsMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                System.Windows.Forms.Cursor.Show();
                this.IsDragging = false;
            }
        }

        private void BaseFaceMouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Hide();
        }
        private void BaseFaceMouseLeave(object sender, EventArgs e)
        {

            System.Windows.Forms.Cursor.Show();
        }

        private void YLocation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
