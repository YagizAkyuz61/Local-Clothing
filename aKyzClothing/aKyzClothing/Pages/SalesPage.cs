using AForge.Video;
using AForge.Video.DirectShow;
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
using ZXing;

namespace aKyzClothing.Pages
{
    public partial class SalesPage : Form
    {
        public SalesPage()
        {
            InitializeComponent();
        }
        static String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\akyz6\OneDrive\Masaüstü\DOSYALAR\Kodlamalar\VS Forms\aKyzClothing\aKyzClothing\Pages\ClothingDatabase.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection connection = new SqlConnection(connectionString);
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        private void SalesPage_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //List();

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
                cameraCB.Items.Add(device.Name);
            cameraCB.SelectedIndex = 0;
        }

        public void List()
        {
            SqlDataAdapter product = new SqlDataAdapter("Select ProductsTable.Barcode, ProductsTable.Name, ProductsTable.Gender, ProductsTable.ProductColor as'Color', CategoryTable.CategoryName, ProductsTable.Price from ProductsTable inner join CategoryTable on CategoryTable.Id=ProductsTable.Category", connection);
            SqlDataAdapter customer = new SqlDataAdapter("Select * From CustomerTable", connection);

            DataSet productDS = new DataSet();
            DataSet customerDS = new DataSet();

            product.Fill(productDS);
            customer.Fill(customerDS);

            dataGridView1.DataSource = productDS.Tables[0];
            dataGridView2.DataSource = customerDS.Tables[0];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLABEL.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString();
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select ProductsTable.Barcode, ProductsTable.Name, ProductsTable.Gender, ProductsTable.ProductColor as'Color', CategoryTable.CategoryName from ProductsTable inner join CategoryTable on CategoryTable.Id=ProductsTable.Category where Barcode like'" + sBarcodeTXT.Text + "'", connection);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void sPnBTN_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from CustomerTable where PhoneNumber='"+sPhoneTXT.Text+"'", connection);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void refleshBTN_Click(object sender, EventArgs e)
        {
            List();
        }

        private void barcodeTXT_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select ProductsTable.Barcode, ProductsTable.Name, ProductsTable.Gender, ProductsTable.ProductColor as'Color', CategoryTable.CategoryName from ProductsTable inner join CategoryTable on CategoryTable.Id=ProductsTable.Category where Barcode like'" + barcodeTXT.Text + "'", connection);
            SqlDataAdapter customer = new SqlDataAdapter("Select * From CustomerTable", connection);
            
            DataSet ds = new DataSet();
            DataSet dss = new DataSet();

            sda.Fill(ds);
            customer.Fill(dss);

            dataGridView1.DataSource = ds.Tables[0];
            dataGridView2.DataSource = dss.Tables[0];

            BarcodeWriter writer = new BarcodeWriter()
            {
                Format = BarcodeFormat.CODE_128
            };
            barcodePB.Image = writer.Write(barcodeTXT.Text);
        }

        private void acceptBTN_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into OrderTable(ProductBarcode, CustomerId, Date)VALUES('" + pBarcodeTXT.Text + "', '" + customerIdTXT.Text + "', '" + dateLABEL.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            List();
            pBarcodeTXT.Clear();
            customerIdTXT.Clear();
            Stock();
        }

        private void rejectBTN_Click(object sender, EventArgs e)
        {
            pBarcodeTXT.Clear();
            customerIdTXT.Clear();
        }

        private void startBTN_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cameraCB.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                barcodeTXT.Invoke(new MethodInvoker(delegate ()
                {
                    barcodeTXT.Text = result.ToString();
                }));
            }
            cameraPB.Image = bitmap;
        }

        private void stopBTN_Click(object sender, EventArgs e)
        {
            if(videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
        }

        private void SalesPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selected];
            pBarcodeTXT.Text = selectedRow.Cells[0].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[selected];
            customerIdTXT.Text = selectedRow.Cells[0].Value.ToString();
        }

        private void menuBTN_Click(object sender, EventArgs e)
        {
            MenuPage page = new MenuPage();
            page.Show();
            this.Hide();

            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
        }

        private void cInsertBTN_Click(object sender, EventArgs e)
        {
            CustomerPage customerPage = new CustomerPage();
            customerPage.Show();
            this.Hide();

            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
        }

        public void Stock()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update StockTable set Stock=Stock-1 where ProductBarcode like'" + barcodeTXT.Text+"'", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
