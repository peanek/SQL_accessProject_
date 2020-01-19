using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udemy_LearnCSharpWithWF_18_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1_Click(sender,e);
            button2_Click(sender,e);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            foreach (var cha in textBox1.Text)
            {
                if (char.IsLetter(cha))
                {
                    label1.Text += $"{cha}\n" ;
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            foreach (var cha in textBox1.Text)
            {
                if (char.IsNumber(cha))
                {
                    label2.Text += $"{cha}\n";
                }
            }

        }
    }
}
