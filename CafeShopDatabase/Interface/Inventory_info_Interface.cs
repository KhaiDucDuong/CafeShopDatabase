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
    public partial class Inventory_info_Interface : Form
    {
        public Inventory_info_Interface()
        {
            InitializeComponent();
        }

        private void Inventory_info_Interface_Load(object sender, EventArgs e)
        {

        }

        private void reloadBt_Click(object sender, EventArgs e)
        {

        }

        private void editBt_Click(object sender, EventArgs e)
        {

        }

        private void cancelBt_Click(object sender, EventArgs e)
        {

        }

        private void addBt_Click(object sender, EventArgs e)
        {

        }

        private void saveBt_Click(object sender, EventArgs e)
        {

        }

        private void deleteBt_Click(object sender, EventArgs e)
        {

        }

        private void CheckInventoryBt_Click(object sender, EventArgs e)
        {
            Inventory_Interface curForm = new Inventory_Interface();
            curForm.Show();
            this.Hide();
        }

        //private void checkRealTimeInventoryBt_Click(object sender, EventArgs e)
        //{
        //    RealTime_Inventory_Interface curForm = new RealTime_Inventory_Interface();
        //    curForm.Show();
        //    this.Hide();
        //}

        private void goBackBt_Click(object sender, EventArgs e)
        {
            DatabaseMenu curForm = new DatabaseMenu();
            curForm.Show();
            this.Hide();
        }
    }
}
