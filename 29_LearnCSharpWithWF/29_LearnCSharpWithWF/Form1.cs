using System;
using System.Windows.Forms;
using System.IO;

namespace _29_LearnCSharpWithWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = $"{MathMetods.Add(numericUpDown1.Value, numericUpDown2.Value)}";
            label2.Text = $"{MathMetods.Divide(numericUpDown1.Value, numericUpDown2.Value)}";

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = $"{MathMetods.Add(numericUpDown1.Value, numericUpDown2.Value)}";
            label2.Text = $"{MathMetods.Divide(numericUpDown1.Value, numericUpDown2.Value)}";

        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            //textBox1.Text = folderBrowserDialog1.SelectedPath;
            //if (!(textBox1.Text == ""))
            //{
            //    button1.Enabled = true;
            //}

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.Enabled = true;
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = "";
            string[] filesArray = Directory.GetFiles(textBox1.Text);
            foreach (string file in filesArray)
            {
                richTextBox1.Text += $"{file}\n";
            }
        }
    }
}
