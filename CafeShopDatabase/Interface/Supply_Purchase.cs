﻿using System;
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
    public partial class Supply_Purchase : Form
    {
        public Supply_Purchase()
        {
            InitializeComponent();
        }

        private void Purchase_info_reload_Click(object sender, EventArgs e)
        {

        }

        private void Purchase_info_edit_Click(object sender, EventArgs e)
        {

        }

        private void Purchase_info_cancel_Click(object sender, EventArgs e)
        {

        }

        private void Purchase_info_add_Click(object sender, EventArgs e)
        {

        }

        private void Purchase_info_save_Click(object sender, EventArgs e)
        {

        }

        private void Purchase_info_delete_Click(object sender, EventArgs e)
        {

        }

        private void supplypurchaseBt_Click(object sender, EventArgs e)
        {
            SupplyPurchase_info curForm = new SupplyPurchase_info();
            curForm.Show();
            this.Hide();
        }

        private void goBackBt_Click(object sender, EventArgs e)
        {
            DatabaseMenu curForm = new DatabaseMenu();
            curForm.Show();
            this.Hide();
        }
    }
}
