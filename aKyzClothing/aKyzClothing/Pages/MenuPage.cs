using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aKyzClothing.Pages
{
    public partial class MenuPage : Form
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void MenuPage_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void hpBTN_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void spBTN_Click(object sender, EventArgs e)
        {
            SalesPage Page = new SalesPage();
            Page.Show();
            this.Hide();
        }

        private void stockPageBTN_Click(object sender, EventArgs e)
        {
            StockPage Page = new StockPage();
            Page.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLABEL.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString();
        }
    }
}
