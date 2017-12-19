using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        Terrarium terrarium;
        public Form1()
        {
            InitializeComponent();
            terrarium = new Terrarium();
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxBig.Width, pictureBoxBig.Height);
            Graphics gr = Graphics.FromImage(bmp);
            terrarium.Draw(gr, pictureBoxBig.Width, pictureBoxBig.Height);
            pictureBoxBig.Image = bmp;
        }
        private void buttonSetSnake_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var Snake = new PoisonousSnake(100, 15, 16, 200, dialog.Color, Color.Yellow);
                int place = terrarium.putSnakeInTerrarium(Snake);
                Draw();
                MessageBox.Show("Место: " + place);
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
            if (maskedTextBox1.Text != "")
            {
                var Snake = terrarium.getSnakeInTerrarium(Convert.ToInt32(maskedTextBox1.Text));
                Bitmap bmp = new Bitmap(pictureBoxSmall.Width, pictureBoxSmall.Height);
                Graphics gr = Graphics.FromImage(bmp);
                Snake.setPosition(47, 47);
                Snake.drawAnimal(gr);
                pictureBoxSmall.Image = bmp;
                Draw();
            }
        }
    }
}
