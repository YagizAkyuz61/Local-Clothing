using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aKyzClothing.Pages
{
    public partial class CustomerPage : Form
    {
        static String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\akyz6\OneDrive\Masaüstü\DOSYALAR\Kodlamalar\VS Forms\aKyzClothing\aKyzClothing\Pages\ClothingDatabase.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection connection = new SqlConnection(connectionString);
        public CustomerPage()
        {
            InitializeComponent();
        }

        private void insertBTN_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into CustomerTable(Name, Surname, PhoneNumber, Address)VALUES('" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Registration Successful", "Successful");
            SalesPage page = new SalesPage();
            page.Show();
            this.Hide();
        }

        private void menuBTN_Click(object sender, EventArgs e)
        {
            SalesPage page = new SalesPage();
            page.Show();
            this.Hide();
        }
    }
}
