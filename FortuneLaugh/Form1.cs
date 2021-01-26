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
        private Game game;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LeftEye.SetTextBox(LeftEyeLocation,"左目");
            LeftEye.SetOriginPic();

            RightEye.SetTextBox(RightEyeLocation,"右目");
            RightEye.SetOriginPic();

            Nose.SetTextBox(NoseLocation,"鼻");
            Nose.SetOriginPic();

            Mouse.SetTextBox(MouseLocation,"口");
            Nose.SetOriginPic();
            game = new Game();

        }

        private void MouseMoveOnForm(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.CursorPointOnForm = this.PointToClient(Cursor.Position);
            CursorLocation.Text = "\tX = " + this.CursorPointOnForm.X + " Y = " + this.CursorPointOnForm.Y;
        }

        private void PartsMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (sender is Picture picture && e.Button == MouseButtons.Left)
            {
                this.CursorPointOnForm = this.PointToClient(Cursor.Position);
                this.DifferenceXFromItem = this.CursorPointOnForm.X - picture.Left;
                this.DifferenceYFromItem = this.CursorPointOnForm.Y - picture.Top;
                picture.PictureMouseDown(Cursor.Position.X + this.DifferenceXFromItem, Cursor.Position.Y + this.DifferenceYFromItem);
                this.IsDragging = true;
            }
        }

        private void PartsMouseMove(object sender, MouseEventArgs e)
        {
            if (sender is Picture picture && e.Button == MouseButtons.Left && IsDragging)
            {
                this.CursorPointOnForm = this.PointToClient(Cursor.Position);
                picture.PictureMouseMove(CursorPointOnForm.X - DifferenceXFromItem, CursorPointOnForm.Y - DifferenceYFromItem, this.ClientSize);
            }
        }

        private void PartsMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.IsDragging = false;
            }
        }

        private void ScoringClicked(object sender, EventArgs e)
        {
            VisualizeFace();
            double score = game.Scoring(LeftEye.Location, RightEye.Location, Nose.Location, Mouse.Location);
            scoreBox.Text = score.ToString() + "点";
        }

        private void VisualizeFace()
        {

        }

        private void BaseFaceMouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Hide();
        }
        private void BaseFaceMouseLeave(object sender, EventArgs e)
        {

            System.Windows.Forms.Cursor.Show();
        }

        private void PartsMouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Hide();
        }
        private void PartsMouseLeave(object sender, EventArgs e)
        {

            System.Windows.Forms.Cursor.Show();
        }

        private void RelativeCheckedChanged(object sender, EventArgs e)
        {
            if (relative.Checked)
            {
                game.SetEvaluation(false);
            }
        }

        private void AbsoluteCheckedChanged(object sender, EventArgs e)
        {
            if (absolute.Checked)
            {
                game.SetEvaluation(true);
            }
        }
    }
}
