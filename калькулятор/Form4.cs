//библиотеки
//готовая версия 1.1v
//для формы Form4.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace калькулятор
{
    public partial class Form4 : Form
    {


        public Form4()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                MessageBox.Show("Дискриминант меньше нуля. Корней нет.");
            }
            if (d == 0)
            {
                double x = (-b / 2 * a);
                MessageBox.Show("Дискриминант равен нулю. Корень равен " + x + ".");
            }
            if (d > 0)
            {

                double x1 = ((-b - Math.Sqrt(d)) / 2 * a);
                double x2 = ((-b + Math.Sqrt(d)) / 2 * a);
                MessageBox.Show("Дискриминант равен " + d + ". Первый корень равен " + x1 + ". Второй корень равен " + x2 + ".");
            }
        }
    }
}

