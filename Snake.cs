using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public abstract class Snake:Interface1
    {
        public abstract void drawAnimal(Graphics g);
        public abstract void moveAnimal(Graphics g);

        protected int startPosX;
        protected int startPosY;

        protected int countMouse;

        public virtual int MaxCountBirds { protected set; get; }

        protected int countBirds;

        public virtual int MaxCountMouse { protected set; get; }
        public virtual int MaxSpeed { protected set; get; }
        public Color ColorBody1 { protected set; get; }
        public Color ColorBody2 { protected set; get; }
        public virtual int height { protected set; get; }
        public void setPosition(int x, int y)
        {
            startPosX = x;
            startPosY = y;
        }

        public void eatMouse(int count)
        {
            if (countMouse + count < MaxCountMouse)
            {
                countMouse += count;
            }
        }
        public void eatBirds(int count)
        {
            if (countBirds + count < MaxCountBirds)
            {
                countBirds += count;
            }
        }

        public virtual void setMainColor(Color color)
        {
            ColorBody1 = color;
        }
        public virtual void setDopColor(Color color)
        {
            ColorBody2 = color;
        }
    }
}
