using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void label1_Click(object sender, EventArgs e)
        {
            string hairColor = "Blonde";
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            int arrows = 1;
#pragma warning restore CS0219 // Variable is assigned but its value is never used
            decimal price = 2.99M;
            bool hasArmor = true;
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            double height = 6.5;
#pragma warning restore CS0219 // Variable is assigned but its value is never used
            label1.Text = $"Hair Color {hairColor}\n" +
                $"price is {price}\n" +
                $"Armor is {hasArmor}\n";




        }
        private void msgLabel_Click(object sender, EventArgs e)
        {

        }

        private void textInput_TextChanged(object sender, EventArgs e)
        {
            label2.Text = textInput.Text.ToLower().Trim();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double input = Double.Parse(textBox1.Text);
            label3.Text = $"10% of {input} is {0.1*input}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal firtNumber = Decimal.Parse(textBox2.Text);
            decimal secondNumber = Decimal.Parse(textBox3.Text);

            decimal averageValue = (firtNumber + secondNumber) / 2;

            label4.Text = $"Average of {firtNumber} and {secondNumber} is  {averageValue:C} ";

            decimal
        }
    }
}
