using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int speed = 5;
            if (e.Shift && progressBar1.Value>2)
            {
                speed = 10;
                progressBar1.Value--;
            }

            if (e.KeyCode == Keys.A || e.KeyCode==Keys.Left)
            {
                pictureBox1.Location=new Point(pictureBox1.Location.X-speed, pictureBox1.Location.Y);
            }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + speed, pictureBox1.Location.Y);
            }
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y+speed);
            }
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y-speed);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum) 
            progressBar1.Value++;

        }
    }
}
