using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class PoisonousSnake: Snake
    {
        public double countPoison { set; get; }
        public override int MaxSpeed
        {
            get
            {
                return base.MaxSpeed;
            }
            protected set
            {
                if (value > 0 && value < 300)
                {
                    base.MaxSpeed = value;
                }
                else
                {
                    base.MaxSpeed = 150;
                }
            }
        }
        public override int MaxCountMouse
        {
            get
            {
                return base.MaxCountMouse;
            }
            protected set
            {
                if (value > 0 && value < 30)
                {
                    base.MaxCountMouse = value;
                }
                else
                {
                    base.MaxCountMouse = 29;
                }
            }
        }

        public override int MaxCountBirds
        {
            get
            {
                return base.MaxCountBirds;
            }
            protected set
            {
                if (value > 0 && value < 16)
                {
                    base.MaxCountBirds = value;
                }
                else
                {
                    base.MaxCountBirds = 15;
                }
            }
        }

        public override int height
        {
            get
            {
                return base.height;
            }
            protected set
            {
                if (value > 150 && value < 550)
                {
                    base.height = value;
                }
                else
                {
                    base.height = 500;
                }
            }
        }

        public PoisonousSnake(int maxSpeed, int maxCountMouse, int maxCountBirds, int height, Color color1, Color color2)
        {
            this.MaxSpeed = maxSpeed;
            this.MaxCountMouse = maxCountMouse;
            this.MaxCountBirds = maxCountBirds;
            this.ColorBody1 = color1;
            this.ColorBody2 = color2;
            this.height = height;
            this.countMouse = 0;
            this.countBirds = 0;
            startPosX = 60;
            startPosY = 60;

        }

        public override void moveAnimal(Graphics g)
        {
            startPosX += (MaxSpeed * 50 / height);
            drawAnimal(g);
        }
        public override void drawAnimal(Graphics g)
        {
            drawLightAnimal(g);
        }

        protected virtual void drawLightAnimal(Graphics g)
        {
            Brush brGreen = new SolidBrush(ColorBody1);
            g.FillEllipse(brGreen, startPosX, startPosY, 90, 30);
            g.FillEllipse(brGreen, startPosX - 7, startPosY - 30, 20, 45);
            g.FillEllipse(brGreen, startPosX - 20, startPosY - 45, 25, 20);
            Brush brBlack = new SolidBrush(Color.Black);
            g.FillEllipse(brBlack, startPosX - 16, startPosY - 42, 5, 5);
            g.FillEllipse(brBlack, startPosX - 8, startPosY - 42, 5, 5);
            Pen pen1 = new Pen(ColorBody2, 1);
            Point p1 = new Point(startPosX - 4, startPosY - 25);
            Point p2 = new Point(startPosX - 4, startPosY + 10);
            Point p3 = new Point(startPosX + 4, startPosY - 25);
            Point p4 = new Point(startPosX + 4, startPosY + 10);
            Point p5 = new Point(startPosX, startPosY - 25);
            Point p6 = new Point(startPosX, startPosY + 10);
            g.DrawLine(pen1, p1, p2);
            g.DrawLine(pen1, p3, p4);
            g.DrawLine(pen1, p5, p6);
            Point pp1 = new Point(startPosX + 4, startPosY + 14);
            Point pp2 = new Point(startPosX + 90, startPosY + 14);
            Point pp3 = new Point(startPosX + 4, startPosY + 17);
            Point pp4 = new Point(startPosX + 90, startPosY + 17);
            Point pp5 = new Point(startPosX + 4, startPosY + 20);
            Point pp6 = new Point(startPosX + 90, startPosY + 20);
            g.DrawLine(pen1, pp1, pp2);
            g.DrawLine(pen1, pp3, pp4);
            g.DrawLine(pen1, pp5, pp6);
        }
    }
}
