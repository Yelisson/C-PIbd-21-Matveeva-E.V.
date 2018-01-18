using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Terrarium
    {
        List<ClassArray<Interface1>> terrariumStages;
        int countPlaces = 4;
        int placeSizeWidth = 270;
        int placeSizeHeight = 182;
        int currentLevel;

        public int getCurrentLevel
        {
            get
            {
                return currentLevel;
            }
        }

        public Terrarium(int countStages)
        {
            terrariumStages = new List<ClassArray<Interface1>>(countStages);
            for (int i = 0; i < countStages; i++)
            {
                terrariumStages.Add(new ClassArray<Interface1>(countPlaces, null));
            }
        }

        public void LevelUp()
        {
            if (currentLevel + 1 < terrariumStages.Count)
            {
                currentLevel++;
            }
        }

        public void LevelDown()
        {
            if (currentLevel > 0)
            {
                currentLevel--;
            }
        }

        public int putSnakeInTerrarium(Interface1 PoisonousSnake)
        {
            return terrariumStages[currentLevel] + PoisonousSnake;
        }

        public Interface1 getSnakeInTerrarium(int number)
        {
            return terrariumStages[currentLevel] - number;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < countPlaces - 1; i++)
            {
                var PoisonousSnake = terrariumStages[currentLevel][i];
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
            g.DrawString("L" + (currentLevel + 1), new Font("Arial", 30), new SolidBrush(Color.Blue),
                    placeSizeWidth + 160, 320);
            g.DrawRectangle(pen, 0, 0, (countPlaces) * placeSizeWidth, 1000);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; ++j)
                {
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight,
                        i * placeSizeWidth + 270, j * placeSizeHeight);
                    if (j < 2)
                    {
                        g.DrawString((i * 2 + j + 1).ToString(), new Font("Arial", 30),
                            new SolidBrush(Color.Blue), i * placeSizeWidth + 60, j * placeSizeHeight + 50);
                    }
                }
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 370);
            }
        }
    }
}
