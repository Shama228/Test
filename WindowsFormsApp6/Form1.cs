using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (radioButton2.Checked == true)
                a = a + 25;
            if (radioButton6.Checked == true)
                a = a + 25;
            if (radioButton9.Checked == true)
                a = a + 25;
            if (radioButton15.Checked == true)
                a = a + 25;

            string zxc = a.ToString();
            MessageBox.Show($"Ваш результат {zxc}%");
        }
    }
}
