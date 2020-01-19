using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udemy01_from9th_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sideLenght = double.Parse(textBox1.Text);
            const ushort numberOfSides = 4;
            double perimeter = numberOfSides * sideLenght;

            label2.Text = $"Perimeter is {perimeter}";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //richTextBox1.Text = "";
            //for (int i = 1; i <= 5; i++)
            //{

            //    richTextBox1.Text += $"x is {i}\n";
            //}
            richTextBox1.Clear();
            int x = 1;
            while (x <=5)
            {
                richTextBox1.Text += $"x is {x}\n";
                x++;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //richTextBox1.Text = "";
            //for (int i = 5; i > 0 ; i--)
            //{
            //    richTextBox1.Text += $"x is {i}\n";
            //}
            richTextBox1.Clear();
            int x = 5;
            while (x >= 1)
            {
                richTextBox1.Text += $"x is {x}\n";
                x--;
            }
        }

        private static void countingInReachTextBox(int x)
        {
            

        }

        private void label3_Click(object sender, EventArgs e)
        {
            for (int i = progressBar1.Minimum; i <= progressBar1.Maximum; i++)
            {
                progressBar1.PerformStep();
                richTextBox2.Text += $"i is {i}\n";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            progressBar1.Value = progressBar1.Minimum;
        }
    }
}
