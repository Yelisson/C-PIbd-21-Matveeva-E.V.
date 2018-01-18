using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using(FileStream fs=new FileStream(filename, FileMode.Create))
            {
                using(BufferedStream bs=new BufferedStream(fs))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("CountLevels:" +
                        terrariumStages.Count + Environment.NewLine);
                    fs.Write(info, 0, info.Length);
                    foreach(var level in terrariumStages){
                        info = new UTF8Encoding(true).GetBytes("Level" + Environment.NewLine);
                        fs.Write(info, 0, info.Length);
                        for(int i = 0; i < countPlaces; i++)
                        {
                            var snake = level[i];
                            if (snake != null)
                            {
                                if(snake.GetType().Name=="PoisonousSnake")
                                {
                                    info = new UTF8Encoding(true).GetBytes("PoisonousSnake:");
                                    fs.Write(info, 0, info.Length);
                                }
                                if (snake.GetType().Name == "Kobra")
                                {
                                    info=new UTF8Encoding(true).GetBytes("Kobra:");
                                    fs.Write(info, 0, info.Length);
                                }
                                info = new UTF8Encoding(true).GetBytes(snake.getInfo() + Environment.NewLine);
                                fs.Write(info, 0, info.Length);
                            }
                        }
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
 
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                string s = "";
                using(BufferedStream bs=new BufferedStream(fs))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (bs.Read(b, 0, b.Length) > 0)
                    {
                        s += temp.GetString(b);
                    }
                }
                s = s.Replace("\r", "");
                var strs = s.Split('\n');
                if (strs[0].Contains("CountLevels"))
                {
                    int count = Convert.ToInt32(strs[0].Split(':')[1]);
                    if (terrariumStages != null)
                    {
                        terrariumStages.Clear();
                    }
                    terrariumStages = new List<ClassArray<Interface1>>(count);
                }
                else
                {
                    throw new TerrariumFormatException();
                }
                int counter = -1;
                for(int i = 1; i < strs.Length; ++i)
                {
                    if (strs[i] == "Level")
                    {
                        counter++;
                        terrariumStages.Add(new ClassArray<Interface1>(countPlaces, null));
                    } else if (strs[i].Split(':')[0] == "PoisonousSnake")
                    {
                        Interface1 snake = new PoisonousSnake(strs[i].Split(':')[1]);
                        int number = terrariumStages[counter] + snake;
                        if (number == -1)
                        {
                            return false;
                        }
                    } else if (strs[i].Split(':')[0] == "Kobra")
                    {
                        Interface1 snake = new Kobra(strs[i].Split(':')[1]);
                        int number = terrariumStages[counter] + snake;
                        if (number == -1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
