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
    public partial class RealTime_Inventory_Interface : Form
    {
        public RealTime_Inventory_Interface()
        {
            InitializeComponent();
        }

        private void RealTime_Inventory_Interface_Load(object sender, EventArgs e)
        {

        }

        private void reloadBt_Click(object sender, EventArgs e)
        {

        }

        private void CheckInventoryBt_Click(object sender, EventArgs e)
        {
            Inventory_Interface curForm = new Inventory_Interface();
            curForm.Show();
            this.Hide();
        }

        private void checkInventoryInfoBt_Click(object sender, EventArgs e)
        {
            Inventory_info_Interface curForm = new Inventory_info_Interface();
            curForm.Show();
            this.Hide();
        }

        private void goBackBt_Click(object sender, EventArgs e)
        {

        }
    }
}
