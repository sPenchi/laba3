using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static double sum(double a, double b)
        {
            return a + b;
        }

        public static double razn(double a, double b)
        {
            return a - b;
        }

        public static double umnog(double a, double b)
        {
            return a * b;
        }

        public static double del(double a, double b)
        {
            return a / b;
        }

        public static double step(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public static double koren(double a, double b)
        {
            return Math.Pow(a, 1 / b);
        }

        private void T2_button1_Click(object sender, EventArgs e)
        {
            T2_textBox3.Text = Convert.ToString(sum(Convert.ToDouble(T2_textBox1.Text), Convert.ToDouble(T2_textBox2.Text)));
        }

        private void T2_button4_Click(object sender, EventArgs e)
        {
            T2_textBox3.Text = Convert.ToString(umnog(Convert.ToDouble(T2_textBox1.Text), Convert.ToDouble(T2_textBox2.Text)));
        }

        private void T2_button2_Click(object sender, EventArgs e)
        {
            T2_textBox3.Text = Convert.ToString(razn(Convert.ToDouble(T2_textBox1.Text), Convert.ToDouble(T2_textBox2.Text)));
        }

        private void T2_button5_Click(object sender, EventArgs e)
        {
            T2_textBox3.Text = Convert.ToString(del(Convert.ToDouble(T2_textBox1.Text), Convert.ToDouble(T2_textBox2.Text)));
        }
    }
}
