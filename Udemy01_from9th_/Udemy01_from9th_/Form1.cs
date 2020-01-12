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
    }
}
