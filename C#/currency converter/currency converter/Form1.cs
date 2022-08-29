using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace currency_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double amt;
            double.TryParse(textBox1.Text, out amt);
            textBox2.Text = (amt * 1).ToString("n2");
            textBox3.Text = (amt * 89).ToString("n2");
            textBox4.Text = (amt * 19.94).ToString("n2");
            textBox5.Text = (amt * 1.44).ToString("n2");
            textBox6.Text = (amt * 1.96).ToString("n2");
            textBox7.Text = (amt * 10.59).ToString("n2");
        }
    }
}
