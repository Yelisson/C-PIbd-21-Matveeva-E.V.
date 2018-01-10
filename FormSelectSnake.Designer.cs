namespace Lab5
{
    partial class FormSelectSnake
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelKobra = new System.Windows.Forms.Label();
            this.labelSnake = new System.Windows.Forms.Label();
            this.panelSnake = new System.Windows.Forms.Panel();
            this.pictureBoxSnake = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panelSnake.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnake)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelKobra);
            this.groupBox1.Controls.Add(this.labelSnake);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вид змеи";
            // 
            // labelKobra
            // 
            this.labelKobra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelKobra.Location = new System.Drawing.Point(6, 80);
            this.labelKobra.Name = "labelKobra";
            this.labelKobra.Size = new System.Drawing.Size(98, 21);
            this.labelKobra.TabIndex = 1;
            this.labelKobra.Text = "Кобра";
            this.labelKobra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelKobra_MouseDown);
            // 
            // labelSnake
            // 
            this.labelSnake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSnake.Location = new System.Drawing.Point(6, 34);
            this.labelSnake.Name = "labelSnake";
            this.labelSnake.Size = new System.Drawing.Size(98, 26);
            this.labelSnake.TabIndex = 0;
            this.labelSnake.Text = "Ядовитая змея";
            this.labelSnake.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelSnake_MouseDown);
            // 
            // panelSnake
            // 
            this.panelSnake.AllowDrop = true;
            this.panelSnake.Controls.Add(this.labelDopColor);
            this.panelSnake.Controls.Add(this.labelBaseColor);
            this.panelSnake.Controls.Add(this.pictureBoxSnake);
            this.panelSnake.Location = new System.Drawing.Point(128, 12);
            this.panelSnake.Name = "panelSnake";
            this.panelSnake.Size = new System.Drawing.Size(203, 236);
            this.panelSnake.TabIndex = 1;
            this.panelSnake.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelSnake_DragDrop);
            this.panelSnake.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelSnake_DragEnter);
            // 
            // pictureBoxSnake
            // 
            this.pictureBoxSnake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSnake.Location = new System.Drawing.Point(16, 17);
            this.pictureBoxSnake.Name = "pictureBoxSnake";
            this.pictureBoxSnake.Size = new System.Drawing.Size(168, 112);
            this.pictureBoxSnake.TabIndex = 0;
            this.pictureBoxSnake.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel8);
            this.groupBox2.Controls.Add(this.panel7);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(348, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 235);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цвета";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(24, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(46, 39);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Location = new System.Drawing.Point(24, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(46, 36);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(24, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(46, 36);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Location = new System.Drawing.Point(24, 165);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(46, 34);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel5.Location = new System.Drawing.Point(77, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(47, 39);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Fuchsia;
            this.panel6.Location = new System.Drawing.Point(77, 79);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(47, 36);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Teal;
            this.panel7.Location = new System.Drawing.Point(77, 122);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(47, 36);
            this.panel7.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel8.Location = new System.Drawing.Point(77, 165);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(47, 34);
            this.panel8.TabIndex = 7;
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(16, 145);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(150, 29);
            this.labelBaseColor.TabIndex = 1;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(16, 186);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(150, 29);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragEnter);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(21, 147);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(21, 187);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormSelectSnake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 270);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panelSnake);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSelectSnake";
            this.Text = "FormSelectSnake";
            this.groupBox1.ResumeLayout(false);
            this.panelSnake.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnake)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelKobra;
        private System.Windows.Forms.Label labelSnake;
        private System.Windows.Forms.Panel panelSnake;
        private System.Windows.Forms.PictureBox pictureBoxSnake;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}