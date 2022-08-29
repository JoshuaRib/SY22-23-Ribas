using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double amt = 0;
            double.TryParse(textBox5.Text, out amt);
            textBox6.Text = (amt * .03).ToString("c2");
            this.BackColor = Color.White;
            if (amt > 500)
                this.BackColor = Color.Red;

            Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

    }
}
