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
    public partial class StockPage : Form
    {
        public StockPage()
        {
            InitializeComponent();
        }
        static String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\akyz6\OneDrive\Masaüstü\DOSYALAR\Kodlamalar\VS Forms\aKyzClothing\aKyzClothing\Pages\ClothingDatabase.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection connection = new SqlConnection(connectionString);
        private void StockPage_Load(object sender, EventArgs e)
        {
            List();
            timer1.Start();
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select StockTable.Id, StockTable.ProductBarcode, ProductsTable.Name, StockTable.Stock from StockTable inner join ProductsTable on ProductsTable.Barcode=StockTable.ProductBarcode where ProductBarcode like'" + searchTXT.Text+"'", connection);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        public void List()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select StockTable.Id, ProductsTable.Barcode, ProductsTable.Name, StockTable.Stock from StockTable inner join ProductsTable on ProductsTable.Barcode=StockTable.ProductBarcode", connection);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update StockTable set ProductBarcode='" + barcodeTXT.Text+"', Stock='"+stockTXT.Text+ "' where Id='"+idTXT.Text+"'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            List();
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete StockTable where Id='"+idTXT.Text+"'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            List();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLABEL.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selected];
            idTXT.Text = selectedRow.Cells[0].Value.ToString();
            barcodeTXT.Text = selectedRow.Cells[1].Value.ToString();
            stockTXT.Text = selectedRow.Cells[3].Value.ToString();
        }

        private void menuBTN_Click(object sender, EventArgs e)
        {
            MenuPage page = new MenuPage();
            page.Show();
            this.Hide();
        }
    }
}
