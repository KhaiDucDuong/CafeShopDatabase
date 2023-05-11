using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShopDatabase
{
    public partial class BILL_INFO : Form
    {
        public BILL_INFO()
        {
            InitializeComponent();
        }

        private void btnOpenBill_Click(object sender, EventArgs e)
        {
            BILL bill = new BILL();
            bill.Show();
            this.Hide();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            DatabaseMenu curForm = new DatabaseMenu();
            curForm.Show();
            this.Hide();
        }
    }
}
