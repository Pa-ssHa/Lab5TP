namespace WindowsFormsApp5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Prisma = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.Circle = new System.Windows.Forms.Button();
            this.Paint = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.volue = new System.Windows.Forms.Button();
            this.Diametr = new System.Windows.Forms.Button();
            this.SquareVirt = new System.Windows.Forms.Button();
            this.SquareNorm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Prisma);
            this.panel1.Controls.Add(this.Triangle);
            this.panel1.Controls.Add(this.Circle);
            this.panel1.Controls.Add(this.Paint);
            this.panel1.Location = new System.Drawing.Point(73, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 299);
            this.panel1.TabIndex = 0;
            // 
            // Prisma
            // 
            this.Prisma.Location = new System.Drawing.Point(3, 244);
            this.Prisma.Name = "Prisma";
            this.Prisma.Size = new System.Drawing.Size(170, 52);
            this.Prisma.TabIndex = 3;
            this.Prisma.Text = "Призма";
            this.Prisma.UseVisualStyleBackColor = true;
            this.Prisma.Click += new System.EventHandler(this.Prisma_Click);
            // 
            // Triangle
            // 
            this.Triangle.Location = new System.Drawing.Point(3, 164);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(170, 54);
            this.Triangle.TabIndex = 2;
            this.Triangle.Text = "Правильный треугольник";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // Circle
            // 
            this.Circle.Location = new System.Drawing.Point(6, 82);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(167, 57);
            this.Circle.TabIndex = 1;
            this.Circle.Text = "Окружность";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Paint
            // 
            this.Paint.Location = new System.Drawing.Point(3, 3);
            this.Paint.Name = "Paint";
            this.Paint.Size = new System.Drawing.Size(170, 56);
            this.Paint.TabIndex = 0;
            this.Paint.Text = "Точка";
            this.Paint.UseVisualStyleBackColor = true;
            this.Paint.Click += new System.EventHandler(this.Paint_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.volue);
            this.panel2.Controls.Add(this.Diametr);
            this.panel2.Controls.Add(this.SquareVirt);
            this.panel2.Controls.Add(this.SquareNorm);
            this.panel2.Location = new System.Drawing.Point(561, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 299);
            this.panel2.TabIndex = 1;
            // 
            // volue
            // 
            this.volue.Location = new System.Drawing.Point(0, 244);
            this.volue.Name = "volue";
            this.volue.Size = new System.Drawing.Size(180, 49);
            this.volue.TabIndex = 3;
            this.volue.Text = "Объем";
            this.volue.UseVisualStyleBackColor = true;
            this.volue.Click += new System.EventHandler(this.volue_Click);
            // 
            // Diametr
            // 
            this.Diametr.Location = new System.Drawing.Point(0, 164);
            this.Diametr.Name = "Diametr";
            this.Diametr.Size = new System.Drawing.Size(180, 51);
            this.Diametr.TabIndex = 2;
            this.Diametr.Text = "Диаметр";
            this.Diametr.UseVisualStyleBackColor = true;
            this.Diametr.Click += new System.EventHandler(this.Diametr_Click);
            // 
            // SquareVirt
            // 
            this.SquareVirt.Location = new System.Drawing.Point(0, 71);
            this.SquareVirt.Name = "SquareVirt";
            this.SquareVirt.Size = new System.Drawing.Size(180, 54);
            this.SquareVirt.TabIndex = 1;
            this.SquareVirt.Text = "Площадь_В";
            this.SquareVirt.UseVisualStyleBackColor = true;
            this.SquareVirt.Click += new System.EventHandler(this.SquareVirt_Click);
            // 
            // SquareNorm
            // 
            this.SquareNorm.Location = new System.Drawing.Point(0, 0);
            this.SquareNorm.Name = "SquareNorm";
            this.SquareNorm.Size = new System.Drawing.Size(180, 42);
            this.SquareNorm.TabIndex = 0;
            this.SquareNorm.Text = "Площадь_О";
            this.SquareNorm.UseVisualStyleBackColor = true;
            this.SquareNorm.Click += new System.EventHandler(this.SquareNorm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Активный класс:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Prisma;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button Paint;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SquareVirt;
        private System.Windows.Forms.Button SquareNorm;
        private System.Windows.Forms.Button Diametr;
        private System.Windows.Forms.Button volue;
        private System.Windows.Forms.Label label1;
    }
}

