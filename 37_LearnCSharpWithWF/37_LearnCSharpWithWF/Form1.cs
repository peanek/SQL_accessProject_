using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _37_LearnCSharpWithWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            var values = textBox1.Text.Split(new char[] { ',', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
            var valuesNumeric = Array.ConvertAll(values, decimal.Parse);
            label1.Text = $"{valuesNumeric.Sum()}";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.Text = "";

            var words = richTextBox1.Text.Split(new char[] { ' ',',', ';', '.' });

            var count = words.Count(word => word.Length >= 5);
            richTextBox2.Text = $"Number of 5 lenght words are : {count}";
            richTextBox2.Text += "\n Words sorted ";
            var logWords = words.Where(word => word.Length >= 5).ToList();
            //string[] wordss = { richTextBox1.Text.Split(new char[] { ' ', ',', ';', '.' } )};
            //var list = wordss.ToList();
            //richTextBox2.Text = list.ToString();

            var logWordsSorte = logWords.OrderBy(word=>word.Length).ToList();
            logWordsSorte.ForEach(word => richTextBox2.Text += $"\n{word}");
            //foreach (var item in logWordsSorte)
            //{
            //    richTextBox2 += item;
            //}

            //foreach (var item in logWordsSorte)
            //{
            //    richTextBox2 += item;
            //}

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            richTextBox4.Text = "";
            var words = richTextBox3.Text.Split(',','!',';',':',' ');
            var count = words.Count(word => word.Length>=5);
            richTextBox4.Text = $"The numberrs of long words is number : {count}";

            richTextBox4.Text += $"\nWords in order are : \n";
            var logLongWords = words.Where(word => word.Length >= 5).ToList();

            var logLongWordsOrder = logLongWords.OrderBy(word=>word.Length).ToList();
            logLongWordsOrder.ForEach(word=> richTextBox4.Text += $"\n{word}");

        }
    }
}
