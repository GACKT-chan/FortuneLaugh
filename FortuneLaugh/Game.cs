using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneLaugh
{
    class Game
    {
        private bool ifAbsolute;
        private bool ifRelative;
        private Point maxLeft;
        private Point maxRight;
        private Point maxNose;
        private Point maxMouse;

        public Game()
        {
            this.ifAbsolute = true;
            this.ifRelative = false;
            SetMaxPosition();
        }

        Game(bool abs, bool rel)
        {
            this.ifAbsolute = abs;
            this.ifRelative = rel;
        }

        private void SetMaxPosition()
        {
            this.maxLeft = new Point(345, 115);
            this.maxRight = new Point(428, 115);
            this.maxNose = new Point(401, 165);
            this.maxMouse = new Point(364, 220);

        }

        public double Scoring(Point left, Point right, Point nose, Point mouse)
        {
            if (ifAbsolute)
            {
                return AbsoluteScoring(left, right, nose, mouse);
            }
            if (ifRelative)
            {
                return RelativeScoring(left, right, nose, mouse);
            }
            return 0;
        }

        public double AbsoluteScoring(Point left, Point right, Point nose, Point mouse)
        {
            int leftRange = (left.X - this.maxLeft.X) * (left.X - this.maxLeft.X) + (left.Y - this.maxLeft.Y) * (left.Y - this.maxLeft.Y);
            int rightRange = (right.X - this.maxRight.X) * (right.X - this.maxRight.X) + (right.Y - this.maxRight.Y) * (right.Y - this.maxRight.Y);
            int mouseRange = (mouse.X - this.maxMouse.X) * (mouse.X - this.maxMouse.X) + (mouse.Y - this.maxMouse.Y) * (mouse.Y - this.maxMouse.Y);
            int noseRange = (nose.X - this.maxNose.X) * (nose.X - this.maxNose.X) + (nose.Y - this.maxNose.Y) * (nose.Y - this.maxNose.Y);


            return 1000 - (leftRange + rightRange + mouseRange + noseRange)/10;
        }

        public double RelativeScoring(Point left, Point right, Point nose, Point mouse)
        {
            return 0;
        }

        public void SetEvaluation(bool ifAbs)
        {
            if (ifAbs)
            {
                this.ifAbsolute = true;
                this.ifRelative = false;
            }
            else
            {
                this.ifAbsolute = false;
                this.ifRelative = true ;
            }
        }

    }
}
//100点の座標
//LeftEye:345,115
//RightEye:428,115
//Nose:401,165
//Mouse:364,220
