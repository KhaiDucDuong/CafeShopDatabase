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

using CafeShopDatabase.ADO.NET_classes.BL;
using System.Data.SqlClient;

namespace CafeShopDatabase
{
    public partial class item : Form
    {
        DataTable dt;
        bool add;
        string error = "";
        BL_item db = new BL_item();

        public item()
        {
            InitializeComponent();
        }

        private void item_Load(object sender, EventArgs e)
        {
            loadData();
        }

        //get data from Item table
        private void loadData()
        {
            try
            {
                getDataFromTable();

                setInputButtonsOff();

                ItemDGV_CellClick(null, null);
            }
            catch(SqlException)
            {
                MessageBox.Show("Failed to get data from the requested Table!", "Load Data error");            
            }
        }

        //get data from Item table again
        private void reloadBT_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void editBT_Click(object sender, EventArgs e)
        {
            if (ItemDGV.RowCount >= 2)
            {
                add = false;

                setInputButtonsOn();

                ItemDGV_CellClick(null, null);

                this.itemName_TB.Focus();
            }
        }

        private void cancelBT_Click(object sender, EventArgs e)
        {
            setInputButtonsOff();

            ItemDGV_CellClick(null, null);
        }

        private void addBT_Click(object sender, EventArgs e)
        {
            add = true;

            setInputButtonsOn();

            this.item_idTB.Focus();
        }

        private void saveBT_Click(object sender, EventArgs e)
        {
            if(add)
            {
                addRow();
            }
            else
            {
                updateRow();
            }
        }

        private void deleteBT_Click(object sender, EventArgs e)
        {
            if(ItemDGV.RowCount >= 2)
            {
                int rowIndex = ItemDGV.CurrentCell.RowIndex;

                string selectedItemID = ItemDGV.Rows[rowIndex].Cells[0].Value.ToString();

                deleteRow(selectedItemID);
            }
        }

        private void goBackBt_Click(object sender, EventArgs e)
        {
            DatabaseMenu curForm = new DatabaseMenu();
            curForm.Show();
            this.Hide();
        }

        private void addRow()
        {
            try
            {
                db.addNewRow(this.item_idTB.Text, this.itemName_TB.Text, this.itemPriceTB.Text, ref error);

                loadData();

                if(!printError())
                    MessageBox.Show("Add a new row successfully!", "Non Query execution status");
            }
            catch (SqlException)
            {
                MessageBox.Show("Failed to add a new row!", "Non Query execution status");
            }
        }
        private void updateRow()
        {
            try
            {
                db.updateRow(this.item_idTB.Text, this.itemName_TB.Text, this.itemPriceTB.Text, ref error);
                loadData();
                if(!printError())
                    MessageBox.Show("Update a new row successfully!", "Non Query execution status");
            }
            catch (SqlException)
            {
                MessageBox.Show("Failed to update a new row!", "Non Query execution status");
            }
        }
        private void deleteRow(string selectedItemID)
        {
            DialogResult answer;

            answer = MessageBox.Show("Do you want to delete this row?", "Deleting row", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                db.removeRow(selectedItemID, ref error);
                loadData();
                if(!printError())
                    MessageBox.Show("Delete selected row successfully!", "Deletion status");
                
            }
        }

        private void getDataFromTable()
        {
            dt = new DataTable();
            dt.Clear();

            DataSet ds = db.getData();
            dt = ds.Tables[0];

            ItemDGV.DataSource = dt;
            ItemDGV.AutoResizeColumns();
        }
        private void setInputButtonsOff()
        {
            this.item_idTB.ResetText();
            this.itemName_TB.ResetText();
            this.itemPriceTB.ResetText();

            this.saveBT.Enabled = false;
            this.cancelBT.Enabled = false;
            this.InputPanel.Enabled = false;

            this.addBT.Enabled = true;
            this.editBT.Enabled = true;
            this.deleteBT.Enabled = true;
            this.goBackBt.Enabled = true;
        }

        private void setInputButtonsOn()
        {
            this.item_idTB.ResetText();
            this.itemName_TB.ResetText();
            this.itemPriceTB.ResetText();

            this.saveBT.Enabled = true;
            this.cancelBT.Enabled = true;
            this.InputPanel.Enabled = true;

            this.addBT.Enabled = false;
            this.editBT.Enabled = false;
            this.deleteBT.Enabled = false;
            this.goBackBt.Enabled = false;
        }

        private bool printError()
        {
            if (error == "")
                return false;

            MessageBox.Show(error, "Error message");
            error = "";

            return true;
        }

        //display the selected row data on the input panel text boxes
        private void ItemDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(ItemDGV.RowCount >= 2)
            {
                int rowIndex = ItemDGV.CurrentCell.RowIndex;

                this.item_idTB.Text = ItemDGV.Rows[rowIndex].Cells[0].Value.ToString();
                this.itemName_TB.Text = ItemDGV.Rows[rowIndex].Cells[1].Value.ToString();
                this.itemPriceTB.Text = ItemDGV.Rows[rowIndex].Cells[2].Value.ToString();
            }
        }


    }
}
