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
    public partial class FormSelectSnake : Form
    {
        Interface1 snake = null;

        public Interface1 getSnake { get { return snake; } }
        private void Draw()
        {
            if (snake != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxSnake.Width, pictureBoxSnake.Height);
                Graphics gr = Graphics.FromImage(bmp);
                snake.setPosition(45, 45);
                snake.drawAnimal(gr);
                pictureBoxSnake.Image = bmp;

            }
        }

        private event myDel eventAddSnake;
        public void AddEvent(myDel ev)
        {
            if (eventAddSnake == null)
            {
                eventAddSnake = new myDel(ev);
            }
            else
            {
                eventAddSnake += ev;
            }
        }
        public FormSelectSnake()
        {
            InitializeComponent();
            panel1.MouseDown += panelColor_MouseDown;
            panel2.MouseDown += panelColor_MouseDown;
            panel3.MouseDown += panelColor_MouseDown;
            panel4.MouseDown += panelColor_MouseDown;
            panel5.MouseDown += panelColor_MouseDown;
            panel6.MouseDown += panelColor_MouseDown;
            panel7.MouseDown += panelColor_MouseDown;
            panel8.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };

        }
 

    

        private void labelKobra_MouseDown(object sender, MouseEventArgs e)
        {
            labelKobra.DoDragDrop(labelKobra.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelSnake_MouseDown(object sender, MouseEventArgs e)
        {
            labelSnake.DoDragDrop(labelSnake.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelSnake_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;

        }
        private void panelSnake_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Ядовитая змея":
                    snake= new PoisonousSnake(100, 15, 16, 200, Color.Blue, Color.Red);
                    Draw();
                    break;
                case "Кобра":
                    snake = new Kobra(100, 15, 16, 200, Color.Green, true, true, Color.Yellow);
                    Draw();
                    break;
            }

        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
                DragDropEffects.Move | DragDropEffects.Copy);
        }


        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;

        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (snake != null)
            {
                snake.setMainColor((Color)e.Data.GetData(typeof(Color)));
                Draw();
            }

        }

        private void labelDopColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (snake != null)
            {
                
                snake.setDopColor((Color)e.Data.GetData(typeof(Color)));
                Draw();

            }

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (eventAddSnake != null)
            {
                eventAddSnake(snake);
            }
            Close();

        }

    
    }
}
