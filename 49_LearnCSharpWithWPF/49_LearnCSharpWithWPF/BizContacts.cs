using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _49_LearnCSharpWithWPF
{
    public partial class BizContacts : Form
    {
        string connString = @"Data Source=DESKTOP-HS1PAQJ\SQLEXPRESS;User ID=sa;Password=bitron0102$;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlDataAdapter dataAdapter;
        DataTable table;


        public BizContacts()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void BizContacts_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            dataGridView1.DataSource = bindingSource1;
            GetData("SELECT * FROM BizContacts");
        }

        private void GetData(string selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand,connString);
                table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
