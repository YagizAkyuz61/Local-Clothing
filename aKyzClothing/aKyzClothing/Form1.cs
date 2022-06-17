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

namespace aKyzClothing
{
    public partial class Form1 : Form
    {
        String connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ClothingDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List();
        }

        public void List()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            SqlDataAdapter product = new SqlDataAdapter("Select ProductsTable.Barcode, ProductsTable.Name, ProductsTable.Gender, ProductsTable.ProductColor, CategoryTable.CategoryName from ProductsTable inner join CategoryTable on CategoryTable.Id=ProductsTable.Category", connection);
            SqlDataAdapter order = new SqlDataAdapter("Select OrderTable.Id, ProductsTable.Barcode, ProductsTable.Name, CustomerTable.Name, CustomerTable.Surname, OrderTable.Date from OrderTable inner join ProductsTable on ProductsTable.Barcode=OrderTable.ProductBarcode inner join CustomerTable on CustomerTable.Id=OrderTable.CustomerId", connection);
            SqlDataAdapter customer = new SqlDataAdapter("Select * from CustomerTable", connection);

            DataSet productDS = new DataSet();
            DataSet orderDS = new DataSet();
            DataSet customerDS = new DataSet();

            product.Fill(productDS);
            order.Fill(orderDS);
            customer.Fill(customerDS);

            //dataGridView.DataSource = orderDS.Tables[0];
        }
    }
}
