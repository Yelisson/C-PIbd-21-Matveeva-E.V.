using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        Terrarium terrarium;

        FormSelectSnake form;
        public Form1()
        {
            InitializeComponent();
            terrarium = new Terrarium(5);
            for (int i = 1; i < 6; i++)
            {
                listBoxLevels.Items.Add("Уровень " + i);
            }
            listBoxLevels.SelectedIndex = terrarium.getCurrentLevel;
            Draw();
        }

        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxBig.Width, pictureBoxBig.Height);
                Graphics gr = Graphics.FromImage(bmp);
                terrarium.Draw(gr);
                pictureBoxBig.Image = bmp;
            }
        }
        private void buttonSetSnake_Click(object sender, EventArgs e)
        {

            form = new FormSelectSnake();
            form.AddEvent(AddSnake);
            form.Show();

        }

        private void AddSnake(Interface1 snake)
        {
            if (snake != null)
            {
                int place = terrarium.putSnakeInTerrarium(snake);
                if (place > -1)
                {
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
                else
                {
                    MessageBox.Show("Машину не удалось поставить");
                }
            }
        }


        private void buttonSetKobra_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var Snake = new Kobra(100, 15, 16, 200, dialog.Color, true, true, dialogDop.Color);
                    int place = terrarium.putSnakeInTerrarium(Snake);
                    Draw();
                    MessageBox.Show("Место: " + place);
                }
            }
        }

        private void buttonGetSnake_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                string level = listBoxLevels.Items[listBoxLevels.SelectedIndex].ToString();
                if (maskedTextBox1.Text != "")
                {
                    Interface1 Snake = terrarium.getSnakeInTerrarium(Convert.ToInt32(maskedTextBox1.Text));
                    if (Snake != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxSmall.Width, pictureBoxSmall.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        Snake.setPosition(50, 50);
                        Snake.drawAnimal(gr);
                        pictureBoxSmall.Image = bmp;
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Извинте, на этом месте нет машины");
                    }
                }
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            terrarium.LevelDown();
            listBoxLevels.SelectedIndex = terrarium.getCurrentLevel;
            Draw();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            terrarium.LevelUp();
            listBoxLevels.SelectedIndex = terrarium.getCurrentLevel;
            Draw();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (terrarium.SaveData(saveFileDialog1.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    MessageBox.Show("Не сохранилось", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (terrarium.LoadData(openFileDialog1.FileName))
                {
                    MessageBox.Show("Загрузили", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не загрузили", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }
    }
}
