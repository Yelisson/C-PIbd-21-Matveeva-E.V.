using NLog;
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
        private Logger log;
        FormSelectSnake form;
        //OpenFileDialog openFileDialog1 = new OpenFileDialog();
        //openFileDialog1.InitialDirectory = "c:\\" ;
        
        public Form1()
        {
            InitializeComponent();
            log = LogManager.GetCurrentClassLogger();
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
                try
                {
                    int place = terrarium.putSnakeInTerrarium(snake);
                    log.Info("Отдали змею");
                    Draw();
                    MessageBox.Show("Ваше место " + place);
                }catch(TerrariumOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка переполнения",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Общая ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    log.Info("Отдали змею");
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
                    try
                    {
                        Interface1 Snake = terrarium.getSnakeInTerrarium(Convert.ToInt32(maskedTextBox1.Text));
                        Bitmap bmp = new Bitmap(pictureBoxSmall.Width, pictureBoxSmall.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        Snake.setPosition(50, 50);
                        Snake.drawAnimal(gr);
                        pictureBoxSmall.Image = bmp;
                        log.Info("Забрали змею");
                        Draw();
                    }catch(TerrariumIndexOutOfRangeException ex)
                    {
                        MessageBox.Show(ex.Message, "Неверный номер",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Общая ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            terrarium.LevelDown();
            listBoxLevels.SelectedIndex = terrarium.getCurrentLevel;
            log.Info("Переход на уровень ниже.Текущий уровень: " + terrarium.getCurrentLevel);
            Draw();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            terrarium.LevelUp();
            listBoxLevels.SelectedIndex = terrarium.getCurrentLevel;
            log.Info("Переход на уровень выше.Текущий уровень: " + terrarium.getCurrentLevel);
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
                    log.Info("Сохранение данных в файл");
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {                     
                try
                {
                    if (terrarium.LoadData(openFileDialog1.FileName))
                    {
                            MessageBox.Show("Загрузили", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                            log.Info("Загрузка данных из файла");
                    }
                }
                catch (TerrariumFormatException ex)
                {
                    MessageBox.Show(ex.Message, "Неверный формат",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Общая ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             
             }
             Draw();
         }
    }
 }

