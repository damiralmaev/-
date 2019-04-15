//библиотеки
//готовая версия
//для формы Form2.
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //кнопки

        //кнопка для закрытия

        private void bt1_Click(object sender, EventArgs e)
        {
            Close();
        }

        //кнопка для показа формы Form3.

        private void bt2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
                f.Show();
        }
    }
}
