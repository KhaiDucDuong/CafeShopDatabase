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
    public partial class BILL : Form
    {
        public BILL()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            BILL_INFO bill_info = new BILL_INFO();
            bill_info.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DatabaseMenu curForm = new DatabaseMenu();
            curForm.Show();
            this.Hide();
        }
    }
}
