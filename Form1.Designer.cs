namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxBig = new System.Windows.Forms.PictureBox();
            this.pictureBoxSmall = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.buttonSetSnake = new System.Windows.Forms.Button();
            this.buttonSetKobra = new System.Windows.Forms.Button();
            this.buttonGetSnake = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmall)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBig
            // 
            this.pictureBoxBig.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxBig.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBig.Name = "pictureBoxBig";
            this.pictureBoxBig.Size = new System.Drawing.Size(500, 370);
            this.pictureBoxBig.TabIndex = 0;
            this.pictureBoxBig.TabStop = false;
            // 
            // pictureBoxSmall
            // 
            this.pictureBoxSmall.Location = new System.Drawing.Point(506, 260);
            this.pictureBoxSmall.Name = "pictureBoxSmall";
            this.pictureBoxSmall.Size = new System.Drawing.Size(178, 110);
            this.pictureBoxSmall.TabIndex = 1;
            this.pictureBoxSmall.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Место:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(556, 207);
            this.maskedTextBox1.Mask = "0";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(28, 20);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // buttonSetSnake
            // 
            this.buttonSetSnake.Location = new System.Drawing.Point(524, 12);
            this.buttonSetSnake.Name = "buttonSetSnake";
            this.buttonSetSnake.Size = new System.Drawing.Size(128, 23);
            this.buttonSetSnake.TabIndex = 4;
            this.buttonSetSnake.Text = "Отдать змею";
            this.buttonSetSnake.UseVisualStyleBackColor = true;
            this.buttonSetSnake.Click += new System.EventHandler(this.buttonSetSnake_Click);
            // 
            // buttonSetKobra
            // 
            this.buttonSetKobra.Location = new System.Drawing.Point(524, 42);
            this.buttonSetKobra.Name = "buttonSetKobra";
            this.buttonSetKobra.Size = new System.Drawing.Size(128, 23);
            this.buttonSetKobra.TabIndex = 5;
            this.buttonSetKobra.Text = "Отдать кобру";
            this.buttonSetKobra.UseVisualStyleBackColor = true;
            this.buttonSetKobra.Click += new System.EventHandler(this.buttonSetKobra_Click);
            // 
            // buttonGetSnake
            // 
            this.buttonGetSnake.Location = new System.Drawing.Point(524, 233);
            this.buttonGetSnake.Name = "buttonGetSnake";
            this.buttonGetSnake.Size = new System.Drawing.Size(128, 23);
            this.buttonGetSnake.TabIndex = 6;
            this.buttonGetSnake.Text = "Забрать змею";
            this.buttonGetSnake.UseVisualStyleBackColor = true;
            this.buttonGetSnake.Click += new System.EventHandler(this.buttonGetSnake_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 370);
            this.Controls.Add(this.buttonGetSnake);
            this.Controls.Add(this.buttonSetKobra);
            this.Controls.Add(this.buttonSetSnake);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxSmall);
            this.Controls.Add(this.pictureBoxBig);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBig;
        private System.Windows.Forms.PictureBox pictureBoxSmall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button buttonSetSnake;
        private System.Windows.Forms.Button buttonSetKobra;
        private System.Windows.Forms.Button buttonGetSnake;
    }
}

