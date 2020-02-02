using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33_LearnCSharpWithWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double num;
            for (int i = 0; i < dataGridView1.RowCount - 1 ; i++)
            {
                sum += double.TryParse(dataGridView1[0,i].Value.ToString(),out num)? num: 0.0;
            }
            label1.Text = $"{sum}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal[] values = { numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value };
            //var list = values.ToList();

            decimal max, min, average, sum;
            MathMethods.Summarize(values, out max, out min, out average, out sum);
            

            label2.Text = $"Max {max}\n";
            label2.Text += $"Min {min}\n";
            label2.Text += $"Avg {Math.Round(average, 2)}\n";
            label2.Text += $"Sum {sum}\n";
            label2.Text += $"Avg {Math.Round(average, 2)}\n";

            

            //decimal[] values = {numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value};
            //var list = values.ToList();
            //label2.Text = $"Max is {list.Max()}";


            //foreach (var item in values)
            //{

            //}
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
