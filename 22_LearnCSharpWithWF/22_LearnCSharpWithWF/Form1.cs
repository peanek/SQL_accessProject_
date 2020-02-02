using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_LearnCSharpWithWF
{
    public partial class Form1 : Form
    {
        DateTime dt = DateTime.Parse("25/11/2019");

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //    DateTime date;
            //    string dateFinal = DateTime.TryParse(textBox1.Text, out date) ? date.ToLongDateString() : "Cannot convert";
            DateTime dateee;
            string dateFinal = DateTime.TryParse(textBox1.Text, out dateee) ? dateee.ToLongDateString() : "Cannot convert";
            label1.Text = dateFinal;

        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            trackBar1.Value += 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label2.Text = "4% discount";
            }
            else
            {
                label2.Text = "6% discount";
            }
            if (checkBox1.Checked & checkBox2.Checked)
            {
                label2.Text = "10% discount";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var dateOne = dateTimePicker1.Value;
            var dateTwo = dateTimePicker1.Value.Date;
            if (dateTimePicker1.Value.Date < dt || dateTimePicker1.Value.Date > dt)
            {
                label3.Text = "Qualify for sicount";
            }
            else
            {
                label3.Text = "No dsicount";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            string text = richTextBox1.Text.ToLower();
            foreach (char c in text)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    richTextBox2.Text += c + "\n";
                }
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(trackBar2, trackBar2.Value.ToString());
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(trackBar3, trackBar3.Value.ToString());
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (checkedListBox1.SelectedIndex)
            {
                case 0:
                    label4.Text = Add(trackBar2.Value, trackBar3.Value).ToString();
                    break;
                case 1:
                    label4.Text = Divide(trackBar2.Value, trackBar3.Value).ToString();
                    break;
                default:
                    break;
            }
        }
        private static double Add(double x, double y) => x + y;

        private static double Divide(double x, double y)
        {
            return (y != 0) ? x / y : 0.0;
        }
        
    }
}
