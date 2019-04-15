//библиотеки
//готовая версия 1.0v
//для формы Form1.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace калькулятор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //переменные 

        //переменные для +, -, /, *. 
        string s;
        double a;
        double b;
        double c;

        //для цифр textBox1 

        private void bt1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            if (textBox1.Text == "00")
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            if (textBox1.Text == "00")
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            if (textBox1.Text == "00")
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "3";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            if (textBox1.Text == "00")
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            if (textBox1.Text == "00")
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            if (textBox1.Text == "00")
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "6";
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            if (textBox1.Text == "00")
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            if (textBox1.Text == "00")
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            if (textBox1.Text == "00")
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "9";
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            if (textBox1.Text == "00")
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + "0"; 
        }

        private void bt00_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "00";
            }
        }

        //для цифр textBox2

        private void bt1_2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }
            if (textBox1.Text == "00")
            {
                textBox1.Clear();
            }
            textBox2.Text = textBox2.Text + "1";
        }

        private void bt2_2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }
            if (textBox1.Text == "00")
            {
                textBox1.Clear();
            }
            textBox2.Text = textBox2.Text + "2";
        }

        private void bt3_2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }
            if (textBox1.Text == "00")
            {
                textBox1.Clear();
            }
            textBox2.Text = textBox2.Text + "3";
        }

        private void bt4_2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }
            if (textBox1.Text == "00")
            {
                textBox1.Clear();
            }
            textBox2.Text = textBox2.Text + "4";
        }

        private void bt5_2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }
            if (textBox1.Text == "00")
            {
                textBox1.Clear();
            }
            textBox2.Text = textBox2.Text + "5";
        }

        private void bt6_2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }
            if (textBox1.Text == "00")
            {
                textBox1.Clear();
            }
            textBox2.Text = textBox2.Text + "6";
        }

        private void bt7_2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }
            if (textBox1.Text == "00")
            {
                textBox1.Clear();
            }
            textBox2.Text = textBox2.Text + "7";
        }

        private void bt8_2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }
            if (textBox1.Text == "00")
            {
                textBox1.Clear();
            }
            textBox2.Text = textBox2.Text + "8";
        }

        private void bt9_2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }
            if (textBox1.Text == "00")
            {
                textBox1.Clear();
            }
            textBox2.Text = textBox2.Text + "9";
        }

        private void bt0_2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }
            if (textBox1.Text == "00")
            {
                textBox1.Clear();
            }
            textBox2.Text = textBox2.Text + "0";
        }

        private void bt00_2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = textBox2.Text = "0";
            }
            else
            {
                textBox2.Text = textBox2.Text + "00";
            }
        }

        //кнопки функции для калькулятора

        //кнопки очистки textBox.

        //кнопка для очистки textBox1, textBox2, textBox3.

        private void bt1_3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text = "0";
            textBox2.Text = textBox2.Text = "0";
            textBox3.Text = textBox3.Text = "0";
        }

        //кнопка для очистки textBox1.

        private void bt2_3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text = "0";
        }

        //кнопка для очистки textBox2

        private void bt3_3_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text = "0";
        }

        //кнопка для очистки textBox3

        private void bt4_3_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text = "0";
        }

        //кнопка для очистки одного симбола

        //textBox1.

        private void bt5_3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = textBox1.Text = "0";
            }
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        //textBox2.

        private void bt6_3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = textBox2.Text = "0";
            }
            textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
        }

        //textBox3.

        private void bt7_3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = textBox3.Text = "0";
            }
            textBox3.Text = textBox3.Text.Substring(0, textBox3.Text.Length - 1);
        }

        //для + - и т.д

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                
            }
            else
            {
                s = textBox1.Text;
                a = Convert.ToDouble(s);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {

            }
            else
            {
                s = textBox2.Text;
                b = Convert.ToDouble(s);
            }
        }

        private void btblus_Click(object sender, EventArgs e)
        {
            c = a + b;
            textBox3.Text = Convert.ToString(c);
        }

        private void btminus_Click(object sender, EventArgs e)
        {
            c = a - b;
            textBox3.Text = Convert.ToString(c);
        }

        private void btumnuwos_Click(object sender, EventArgs e)
        {
            c = a * b;
            textBox3.Text = Convert.ToString(c);
        }

        private void btrasdelite_Click(object sender, EventArgs e)
        {
            c = a / b;
            textBox3.Text = Convert.ToString(c);
        }

        //кнопки информации

        //кнопка автора

        private void bt1_4_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        //кнопки доп. функций.

        //кнопка для кв. уравнения.

        private void bt8_3_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }

        //автор Дамир Алмаев Маратович

    }
}