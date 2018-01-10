using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Kobra: PoisonousSnake
    {
        private bool leftHood;
        private bool rightHood;
        private Color dopColor;

        public Kobra(int maxSpeed, int maxCountMouses, int maxCountBirdss, int height,
            Color color1, bool leftHood, bool rightHood,
            Color color2) : base(maxSpeed, maxCountMouses, maxCountBirdss, height, color1, color2)
        {
            this.leftHood = leftHood;
            this.rightHood = rightHood;
            this.dopColor = color2;
        }
        protected override void drawLightAnimal(Graphics g)
        {
            if (leftHood)
            {
                Brush brBlack = new SolidBrush(Color.Black);
                g.FillEllipse(brBlack, startPosX - 14, startPosY - 35, 15, 25);
            }
            if (rightHood)
            {
                Brush brBlack = new SolidBrush(Color.Black);
                g.FillEllipse(brBlack, startPosX + 4, startPosY - 35, 15, 25);
            }

            base.drawLightAnimal(g);
            Pen pen = new Pen(Color.Black, 2);
            Point point1 = new Point(startPosX - 10, startPosY - 30);
            Point point2 = new Point(startPosX - 20, startPosY - 25);
            Point point3 = new Point(startPosX - 25, startPosY - 26);
            Point point4 = new Point(startPosX - 16, startPosY - 21);
            g.DrawLine(pen, point1, point2);
            g.DrawLine(pen, point2, point3);
            g.DrawLine(pen, point2, point4);
        }
    }
}
