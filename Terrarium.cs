using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Terrarium
    {
        ClassArray<Interface1> terrarium;
        int countPlaces = 4;
        int placeSizeWidth = 270;
        int placeSizeHeight = 182;

        public Terrarium()
        {
            terrarium = new ClassArray<Interface1>(countPlaces, null);
        }
        public int putSnakeInTerrarium(Interface1 PoisonousSnake)
        {
            return terrarium + PoisonousSnake;
        }

        public Interface1 getSnakeInTerrarium(int number)
        {
            return terrarium - number;
        }

        public void Draw(Graphics g, int width, int height)
        {
            DrawMarking(g);
            for (int i = 0; i < countPlaces; i++)
            {
                var PoisonousSnake = terrarium.getObject(i);
                if (PoisonousSnake != null)
                {
                    PoisonousSnake.setPosition(35 + i / 2 * placeSizeWidth + 35, i % 2 * placeSizeHeight + 75);
                    PoisonousSnake.drawAnimal(g);
                }
            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, 0, 0, (countPlaces) * placeSizeWidth, 1000);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; ++j)
                {
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth + 270, j * placeSizeHeight);
                }
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 370);
            }
        }
    }
}
