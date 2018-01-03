using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private Interface1 inter;
        Color color1;
        Color color2;
        int maxSpeed;
        int maxCountM;
        int maxCountB;
        int height;
        bool leftH;
        bool rightH;
        double countPoison;
        
        public Form1()
        {
            InitializeComponent();
            color1 = Color.Green;
            color2 = Color.Yellow;
            maxSpeed = 150;
            maxCountM = 16;
            maxCountB = 29;
            countPoison = 20.5;
            height = 200;
            leftH = true;
            rightH = true;
            button4.BackColor = color1;
            button5.BackColor = color2;
        }

        private bool checkFields()
        {
            if (!int.TryParse(textBox1.Text, out maxSpeed))
            {
                return false;
            }
            if (!int.TryParse(textBox2.Text, out maxCountM))
            {
                return false;
            }
            if (!int.TryParse(textBox3.Text, out maxCountB))
            {
                return false;
            }
            if (!int.TryParse(textBox4.Text, out height))
            {
                return false;
            }
            if (!Double.TryParse(textBox5.Text, out countPoison))
            {
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            inter = new PoisonousSnake(maxSpeed, maxCountM, maxCountB, height, color1, color2);
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            inter.drawAnimal(gr);
            pictureBox1.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inter = new Kobra(maxSpeed, maxCountM, maxCountB, height, color1, leftH, rightH, color2);
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            inter.drawAnimal(gr);
            pictureBox1.Image = bmp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (inter != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.moveAnimal(gr);
                pictureBox1.Image = bmp;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                color1 = cd.Color;
                button4.BackColor = color1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                color2 = cd.Color;
                button5.BackColor = color2;
            }
        }
    }
}
