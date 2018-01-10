using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Kobra:PoisonousSnake,IComparable<Kobra>,IEquatable<Kobra>
    {
        public int CompareTo(Kobra other)
        {
            var res = (this is PoisonousSnake).CompareTo(other is PoisonousSnake);
            if (res != 0)
            {
                return res;
            }
            if (leftHood != other.leftHood)
            {
                return leftHood.CompareTo(other.leftHood);
            }
            if (rightHood != other.rightHood)
            {
                return rightHood.CompareTo(other.rightHood);
            }
            if (ColorBody1 != other.ColorBody1)
            {
                return ColorBody1.Name.CompareTo(other.ColorBody1.Name);
            }
            if (ColorBody2 != other.ColorBody2)
            {
                return ColorBody2.Name.CompareTo(other.ColorBody2.Name);
            }
            return 0;
        }

        public bool Equals(Kobra other)
        {
            var res = (this is PoisonousSnake).Equals(other is PoisonousSnake);
            if (!res)
            {
                return res;
            }
            if (leftHood != other.leftHood)
            {
                return false;
            }
            if (rightHood != other.rightHood)
            {
                return false;
            }
            if (ColorBody1 != other.ColorBody1)
            {
                return false;
            }
            if (ColorBody2 != other.ColorBody2)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Kobra kobraObj = obj as Kobra;
            if (kobraObj == null)
            {
                return false;
            }else
            {
                return Equals(kobraObj);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        private bool leftHood;
        private bool rightHood;
        private System.Drawing.Color dopColor;

        public Kobra(int maxSpeed, int maxCountMouses, int maxCountBirdss, int height,
            Color color1, bool leftHood, bool rightHood,
            Color color2) : base(maxSpeed, maxCountMouses, maxCountBirdss, height, color1, color2)
        {
            this.leftHood = leftHood;
            this.rightHood = rightHood;
            this.ColorBody1 = color1;
            this.ColorBody2 = color2;
            //this.mainColor = color1;
           // this.dopColor = color2;
           
        }

        public Kobra(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 8)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                MaxCountMouse= Convert.ToInt32(strs[1]);
                MaxCountBirds= Convert.ToInt32(strs[2]);
                height= Convert.ToInt32(strs[3]);
                ColorBody1 = Color.FromName(strs[4]);
                leftHood = Convert.ToBoolean(strs[5]);
                rightHood = Convert.ToBoolean(strs[6]);
                ColorBody2 = Color.FromName(strs[7]);
            }
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
        public override string getInfo()
        {
            return MaxSpeed + ";" + MaxCountMouse + ";" + MaxCountBirds + ";" + height + ";" + ColorBody1.Name +
                ";" + leftHood + ";" + rightHood + ";" + ColorBody2.Name;
        }
    }
}
