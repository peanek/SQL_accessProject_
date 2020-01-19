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
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DateTime date;
            string dateFinal = DateTime.TryParse(textBox1.Text, out date) ? date.ToLongDateString() : "Cannot convert";
        }
    }
}
