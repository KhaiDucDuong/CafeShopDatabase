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
    public partial class DatabaseMenu : Form
    {
        public DatabaseMenu()
        {
            InitializeComponent();
        }

        private void openBt_Click(object sender, EventArgs e)
        {
            if(DatabaseListBox.SelectedIndex != -1)
            {
                string selectedDatabase = DatabaseListBox.SelectedItem.ToString();
                switch (selectedDatabase)
                {
                    case "Bill":
                        {
                            BILL bill = new BILL();
                            bill.Show();
                            this.Hide();
                            break;
                        }
                    case "Inventory":
                        {
                            Inventory_Interface curForm = new Inventory_Interface();
                            curForm.Show();
                            this.Hide();
                            break;
                        }
                    case "Employee":
                        {
                            Employee curForm = new Employee();
                            curForm.Show();
                            this.Hide();
                            break;
                        }
                    case "Supplier":
                        {
                            Supplier curForm = new Supplier();
                            curForm.Show();
                            this.Hide();
                            break;
                        }
                    default:
                        { 
                            break;
                        }
                }
            }
            //inform user to select a database
            else
            {
                MessageBox.Show("Please select a database to open!", "No selected database");
            }
        }

        private void logoutBt_Click(object sender, EventArgs e)
        {

        }

        private void helpBt_Click(object sender, EventArgs e)
        {

        }

        private void DatabaseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
