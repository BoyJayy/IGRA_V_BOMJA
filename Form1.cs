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
        int x = 0;
        int payment = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text.Split('%')[0] == "YOU DIED")
            {
                label1.Text = "YOU DIED";
            }
            else
            {
                label1.Text = (Convert.ToInt32(label1.Text.Split('%')[0]) + 10).ToString() + "%";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Text.Split('%')[0] == "0")
            {
                label1.Text = "YOU DIED";
                timer1.Stop();
                Application.Exit();
            }
            else
            {
                label1.Text = (Convert.ToInt32(label1.Text.Split('%')[0]) - 10).ToString() + "%";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (label2.Text.Split('%')[0] == "YOU DIED")
                {
                    label2.Text = "YOU DIED";
                }
                else
                {
                    label2.Text = (Convert.ToInt32(label2.Text.Split('%')[0]) + 3).ToString() + "%";
                }
                //if (label2.Text.Split('%')[0] == Convert.ToString(96) || label2.Text.Split('%')[0] == "99" || label2.Text.Split('%')[0] == "100")
                //{
                  //  label2.Text = label2.Text.Split('%')[0];
                //}
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label4.Text.Split('%')[0] == "0")
            {
                label4.Text = "YOU DIED";
                timer2.Stop();
                Application.Exit();
            }
            else
            {
                label4.Text = (Convert.ToInt32(label4.Text.Split('%')[0]) - 25).ToString() + "%";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (label4.Text.Split('%')[0] == "YOU DIED")
            {
                label4.Text = "YOU DIED";
            }
            else
            {
                label4.Text = (Convert.ToInt32(label4.Text.Split('%')[0]) + 25).ToString() + "%";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (label2.Text.Split('%')[0] == "0")
            {
                label2.Text = "YOU DIED";
                timer3.Stop();
                Application.Exit();
            }
            else
            {
                label2.Text = (Convert.ToInt32(label2.Text.Split('%')[0]) - 1).ToString() + "%";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(x);
            x += payment;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "50")
            {
                label5.Text = "Дворник";
                payment = 2;
                label7.Text = "Общажный житель";
            }
            if (textBox1.Text == "150")
            {
                label5.Text = "Продавец в продуктовом";
                payment = 4;
                label7.Text = "Малообеспеченый";
            }
            if (textBox1.Text == "750")
            {
                label5.Text = "Таксист";
                payment = 8;
                label7.Text = "Среднестатистический житель";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        bool ifPlaying = true;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
    
        private void button6_Click(object sender, EventArgs e)
        {
            ifPlaying = true;
            if (ifPlaying)
            {
                player.SoundLocation = @"C:\Users\BoyJayy\source\repos\aaaa\morgen.wav";
                player.Play();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ifPlaying = false;
            if (!ifPlaying)
            {
                player.SoundLocation = @"C:\Users\BoyJayy\source\repos\aaaa\morgen.wav";
                player.Stop(); 
            }
        }
    }
}
