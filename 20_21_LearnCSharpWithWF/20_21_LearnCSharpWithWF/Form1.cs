using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_21_LearnCSharpWithWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = $"Amount is {decimal.Parse(textBox1.Text):C}";
            decimal amount = decimal.Parse(textBox1.Text);
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //decimal amount = decimal.Parse(textBox1.Text);
            //decimal finalAmount = (comboBox1.SelectedIndex == 0) ? amount * 0.9M : amount * 1.1M;
            //label2.Text = finalAmount.ToString();
            //if (comboBox1.SelectedIndex == 0)
            //{
            //    decimal amount = decimal.Parse(textBox1.Text);
            //    decimal finalAmount =(comboBox1.Sl1e)

            //}

            //if (comboBox1.SelectedIndex == 0)
            //{
            //    decimal amount = decimal.Parse(textBox1.Text) * 1.1M ;
            //    label2.Text = amount.ToString();
            //}
            //if (comboBox1.SelectedIndex == 1)
            //{
            //    decimal amount = decimal.Parse(textBox1.Text) * 0.9M;
            //    label2.Text = amount.ToString();
            //}
            decimal amount = decimal.Parse(textBox1.Text);
            decimal finalAmount = (comboBox1.SelectedIndex == 0) ? amount * 1.1M : amount * 0.9M;
            label2.Text = finalAmount.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
