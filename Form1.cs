using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        private paint t;
        private circle circle_obj;
        private triangle triangle_obj;
        private prism prism_obj;
        public Form1()
        {
            InitializeComponent();

            circle_obj = new circle(5);
            triangle_obj = new triangle(4);
            prism_obj = new prism(4, 5);

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public class paint
        {
            public double Square_paint()
            {
                return 0;
            }
            public virtual double Square_calculVirt()
            {
                return 0;
            }
        }
        public class circle : paint
        {
            private double radius;
            public circle(double radius)
            {
                this.radius = radius;
            }
            public double Square_circle()
            {
                return Math.PI * radius * radius;
            }
            public override double Square_calculVirt()
            {
                return Math.PI * radius * radius;
            }
            public double Diameter_circle()
            {
                return radius * 2;
            }
        }
        public class triangle : paint
        {
            public double side;

            public triangle( double side)
            {
                this.side = side;
            }

            public double Square_triangle()
            {
                return side * side * Math.Pow(3, 0.5) / 4;
            }
            public override double Square_calculVirt()
            {
                return side * side * Math.Pow(3, 0.5) / 4;
            }
        }
        public class prism : triangle
        {
            private double height;

            public prism(double side, double height) : base(side)
            {
                this.side = side;
                this.height = height;
            }
            public double Square_prism()
            {
                return Square_triangle() * 2 + height * side * 3;
            }
            public override double Square_calculVirt()
            {
                return side * side * Math.Pow(3, 0.5) / 2 + height * side * 3;
            }
            public double Volue_prism()
            {
                return side * side * Math.Pow(3, 0.5) / 4 * height;
            }
        }

        private void Prisma_Click(object sender, EventArgs e)
        {
            t = prism_obj;
            label1.Text = "Активный класс: " + t.GetType().Name;
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            t = triangle_obj;
            label1.Text = "Активный класс: " + t.GetType().Name;
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            t = circle_obj;
            label1.Text = "Активный класс: " + t.GetType().Name;
        }

        private void Paint_Click(object sender, EventArgs e)
        {
            t = new paint();
            label1.Text = "Активный класс: " + t.GetType().Name;

        }

        private void SquareNorm_Click(object sender, EventArgs e)
        {
            if (t is prism)
            {
                prism active = (prism)t;
                double result = active.Square_prism();
                MessageBox.Show("Площадь: " + result);
            }
            else if (t is circle)
            {
                circle active = (circle)t;
                double result = active.Square_circle();
                MessageBox.Show("Площадь: " + result);
            }
            else if (t is triangle)
            {
                triangle active = (triangle)t;
                double result = active.Square_triangle();
                MessageBox.Show("Площадь: " + result);
            }
            else if (t is paint)
            {
                paint active = (paint)t;
                double result = active.Square_paint();
                MessageBox.Show("Площадь: " + result);
            }
            else
            {
                MessageBox.Show("Выберите объект ");
            }
        }

        private void SquareVirt_Click(object sender, EventArgs e)
        {
            
            if( t != null)
            {
                double result = t.Square_calculVirt();
                MessageBox.Show("Площадь: " + result);
            }
            else
            {
                MessageBox.Show("Выберите объект ");
            }
        }

        private void volue_Click(object sender, EventArgs e)
        {
            if (t == null)
            {
                MessageBox.Show("Выберите объект ");
            }
            else if (t is prism)
            {
                prism active = (prism)t;
                double result = active.Volue_prism();
                MessageBox.Show("Объем: " + result);
            }
            else
            {
                MessageBox.Show("Метод Volue_prism() для активного объекта не определен");

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Diametr_Click(object sender, EventArgs e)
        {
            if( t == null)
            {
                MessageBox.Show("Выберите объект ");              
            }
            else if(t is circle)
            {
                circle active = (circle)t;
                double result = active.Diameter_circle();
                MessageBox.Show("Диаметр: " + result);
            }
            else
            {
                MessageBox.Show("Метод Diameter_circle() для активного объекта не определен");
            }
        }
    }
}
