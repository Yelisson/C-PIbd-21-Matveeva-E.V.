using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    interface Interface1
    {
        void drawAnimal(Graphics g);
        void moveAnimal(Graphics g);
        void setPosition(int x, int y);
        void eatMouse(int countMouse);
        void eatBirds(int countBirds);
    }
}
