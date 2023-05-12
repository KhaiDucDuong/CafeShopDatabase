using CafeShopDatabase;
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
    public partial class item : Form
    {
        public item()
        {
            InitializeComponent();
        }

        private void reloadBT_Click(object sender, EventArgs e)
        {

        }

        private void editBT_Click(object sender, EventArgs e)
        {

        }

        private void cancelBT_Click(object sender, EventArgs e)
        {

        }

        private void addBT_Click(object sender, EventArgs e)
        {

        }

        private void saveBT_Click(object sender, EventArgs e)
        {

        }

        private void deleteBT_Click(object sender, EventArgs e)
        {

        }

        private void goBackBt_Click(object sender, EventArgs e)
        {
            DatabaseMenu curForm = new DatabaseMenu();
            curForm.Show();
            this.Hide();
        }
    }
}
