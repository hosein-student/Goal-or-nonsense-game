using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace سنگ_کاغذ_قیچی
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        int Players = 0;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.sang;
            Players=1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.ka;
            Players=2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.ghe;
            Players = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int bot=0;
                bot=rnd.Next(1,4);
            if(bot==1)
            {
                pictureBox2.Image = Properties.Resources.sang;
            }
            if (bot == 2)
            {
                pictureBox2.Image = Properties.Resources.ka;
            }
            if (bot == 3)
            {
                pictureBox2.Image = Properties.Resources.ghe;

            }
            if (Players==bot)
            {
                MessageBox.Show("دوباره انتخاب کنبد");
            }
            if (Players==1&&bot==2)
            {
                MessageBox.Show("کامپیوتر برنده شد");
            }
            if (Players == 1 && bot == 3)
            {
                MessageBox.Show(" برنده شدید");

            }
            if (Players == 2 && bot == 3)
            {
                MessageBox.Show("کامپیوتر برنده شد");
            }
            if (Players == 2 && bot == 1)
            {
                MessageBox.Show(" برنده شدید");
            }
            if (Players == 3 && bot == 1)
            {
                MessageBox.Show("کامپیوتر برنده شد");
            } 
            if (Players == 3 && bot == 2)
            {
                MessageBox.Show("برنده شدید");
            }

        }
    }
}
