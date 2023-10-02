using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aaaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = (Convert.ToInt32(label1.Text.Split('%')[0]) + 10).ToString() + "%";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = (Convert.ToInt32(label1.Text.Split('%')[0]) - 10).ToString() + "%";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = (Convert.ToInt32(label2.Text.Split('%')[0]) + 2).ToString() + "%";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label4.Text = (Convert.ToInt32(label4.Text.Split('%')[0]) - 25).ToString() + "%";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label4.Text = (Convert.ToInt32(label4.Text.Split('%')[0]) + 25).ToString() + "%";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label2.Text = (Convert.ToInt32(label2.Text.Split('%')[0]) - 1).ToString() + "%";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
