using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _32_LearnCSharpWithWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.Enabled = true;
                textBox1.Text = folderBrowserDialog1.SelectedPath;

                


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] filesArray = Directory.GetFiles(textBox1.Text);
            foreach (string file in filesArray)
            {
                richTextBox1.Text += $"{file}\n";
            }
        }
    }
}
