using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace aKyzClothing.Pages
{
    public partial class HomePage : Form
    {
        static String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\akyz6\OneDrive\Masaüstü\DOSYALAR\Kodlamalar\VS Forms\aKyzClothing\aKyzClothing\Pages\ClothingDatabase.mdf;Integrated Security=True;Connect Timeout=30";
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            List();
            timer1.Start();
        }

        public void List()
        {
            DataSet ds = new DataSet();
            if (productsRB.Checked)
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select ProductsTable.Barcode, ProductsTable.Name, ProductsTable.Gender, ProductsTable.ProductColor as'Color', CategoryTable.CategoryName, ProductsTable.Price from ProductsTable inner join CategoryTable on CategoryTable.Id=ProductsTable.Category", connection);
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                searchBTN.Visible = true;
                searchLBL.Visible = true;
                searchTXT.Visible = true;
            }

            if (stockRB.Checked)
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From StockTable", connection);
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                searchBTN.Visible = true;
                searchLBL.Visible = true;
                searchTXT.Visible = true;
            }

            if (categoryRB.Checked)
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From CategoryTable", connection);
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                searchBTN.Visible = false;
                searchLBL.Visible = false;
                searchTXT.Visible = false;
            }

            if (personRB.Checked)
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From PersonTable", connection);
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                searchLBL.Text = "Name";
                searchBTN.Visible = true;
                searchLBL.Visible = true;
                searchTXT.Visible = true;
            }

            if (orderRB.Checked)
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select OrderTable.Id, ProductsTable.Barcode, ProductsTable.Name as'Product Name', ProductsTable.Price, CustomerTable.Name, CustomerTable.Surname, OrderTable.Date from OrderTable inner join ProductsTable on ProductsTable.Barcode=OrderTable.ProductBarcode inner join CustomerTable on CustomerTable.Id=OrderTable.CustomerId", connection);
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                searchBTN.Visible = false;
                searchLBL.Visible = false;
                searchTXT.Visible = false;
            }

            if (customeRB.Checked)
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From CustomerTable", connection);
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                searchBTN.Visible = false;
                searchLBL.Visible = false;
                searchTXT.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLABEL.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString();
        }

        SqlConnection connection = new SqlConnection(connectionString);
        private void pInsertBTN_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into ProductsTable(Barcode, Name, Gender, ProductColor, Category, Price)values('"+pBarcodeTXT.Text+ "', '" + pNameTXT.Text + "', '" + genderCB.Text + "', '" + pColorCB.Text + "', '" + pCategoryTXT.Text + "', '" + pPriceTXT.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            productsRB.Checked = true;
            List();
            Stock();
        }

        private void pUpdateBTN_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update ProductsTable set Name='" + pNameTXT.Text + "', Gender='" + genderCB.Text + "', ProductColor='" + pColorCB.Text + "', Category='" + pCategoryTXT.Text + "' where Barcode='" + pBarcodeTXT.Text + "' , Price='" + pPriceTXT.Text + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            productsRB.Checked = true;
            List();
        }

        private void pDeleteBTN_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Delete ProductsTable where Barcode='" + pBarcodeTXT.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            productsRB.Checked = true;
            List();
        }

        private void cInsertBTN_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into CategoryTable(CategoryName)values('" + cName.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            categoryRB.Checked = true;
            List();
        }

        private void cUpdateBTN_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update CategoryTable set CategoryName='" + cName.Text + "' where Id='" + cId.Text + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            categoryRB.Checked = true;
            List();
        }

        private void cDeleteBTN_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Delete CategoryTable where Id='" + cId.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            categoryRB.Checked = true;
            List();
        }

        private void peInsertBTN_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into PersonTable(Name, Surname, Role)values('" + peNameTXT.Text + "', '" + peSurnameTXT.Text + "', '" + peRoleCB.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            personRB.Checked = true;
            List();
        }

        private void peUpdateBTN_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update PersonTable set Name='" + peNameTXT.Text + "', Surname='" + peSurnameTXT.Text + "', Role='" + peRoleCB.Text + "' where Id='" + peId.Text + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            personRB.Checked = true;
            List();
        }

        private void peDeleteBTN_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Delete PersonTable where Id='" + peId.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            personRB.Checked = true;
            List();
        }

        private void showBTN_Click(object sender, EventArgs e)
        {
            List();
        }

        public void Stock()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into StockTable(ProductBarcode, Stock)values('" + pBarcodeTXT.Text + "', '" + pStockTXT.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            categoryRB.Checked = true;
            List();
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            if (productsRB.Checked)
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select ProductsTable.Barcode, ProductsTable.Name, ProductsTable.Gender, ProductsTable.ProductColor as'Color', CategoryTable.CategoryName, ProductsTable.Price from ProductsTable inner join CategoryTable on CategoryTable.Id=ProductsTable.Category where Barcode like'" + searchTXT.Text+"'", connection);
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                searchBTN.Visible = true;
                searchLBL.Visible = true;
                searchTXT.Visible = true;
            }

            if (stockRB.Checked)
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From StockTable where Barcode like='"+searchTXT.Text+"'", connection);
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                searchBTN.Visible = true;
                searchLBL.Visible = true;
                searchTXT.Visible = true;
            }

            if (personRB.Checked)
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From PersonTable where Name like='" + searchTXT.Text + "'", connection);
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                searchLBL.Text = "Name";
                searchBTN.Visible = true;
                searchLBL.Visible = true;
                searchTXT.Visible = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selected];
            if (productsRB.Checked)
            {
                pBarcodeTXT.Text = selectedRow.Cells[0].Value.ToString();
            }

            if (categoryRB.Checked)
            {
                cId.Text = selectedRow.Cells[0].Value.ToString();
                cName.Text = selectedRow.Cells[1].Value.ToString();
            }

            if (personRB.Checked)
            {
                peId.Text = selectedRow.Cells[0].Value.ToString();
                peNameTXT.Text = selectedRow.Cells[1].Value.ToString();
                peSurnameTXT.Text = selectedRow.Cells[2].Value.ToString();
                pPriceTXT.Text = selectedRow.Cells[3].Value.ToString();
            }
        }

        private void refleshBTN_Click(object sender, EventArgs e)
        {
            List();
        }

        private void menuBTN_Click(object sender, EventArgs e)
        {
            MenuPage page = new MenuPage();
            page.Show();
            this.Hide();
        }
    }
}
