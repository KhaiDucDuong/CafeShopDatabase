namespace CafeShopDatabase
{
    partial class Inventory_Interface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InventoryDGV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.date_check_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.check_idLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkidTb = new System.Windows.Forms.TextBox();
            this.date_checkLb = new System.Windows.Forms.Label();
            this.Check_ID_textBox = new System.Windows.Forms.TextBox();
            this.reloadBt = new System.Windows.Forms.Button();
            this.addBt = new System.Windows.Forms.Button();
            this.editBt = new System.Windows.Forms.Button();
            this.saveBt = new System.Windows.Forms.Button();
            this.cancelBt = new System.Windows.Forms.Button();
            this.deleteBt = new System.Windows.Forms.Button();
            this.CheckInventoryInfoBt = new System.Windows.Forms.Button();
            this.goBackBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InventoryDGV
            // 
            this.InventoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryDGV.Location = new System.Drawing.Point(17, 175);
            this.InventoryDGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InventoryDGV.Name = "InventoryDGV";
            this.InventoryDGV.RowHeadersWidth = 51;
            this.InventoryDGV.Size = new System.Drawing.Size(457, 239);
            this.InventoryDGV.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.date_check_dateTimePicker);
            this.panel1.Controls.Add(this.check_idLb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.checkidTb);
            this.panel1.Controls.Add(this.date_checkLb);
            this.panel1.Controls.Add(this.Check_ID_textBox);
            this.panel1.Location = new System.Drawing.Point(17, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 153);
            this.panel1.TabIndex = 1;
            // 
            // date_check_dateTimePicker
            // 
            this.date_check_dateTimePicker.CustomFormat = "hh:mm:ss  dd/MM/yyyy";
            this.date_check_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_check_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_check_dateTimePicker.Location = new System.Drawing.Point(221, 60);
            this.date_check_dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.date_check_dateTimePicker.Name = "date_check_dateTimePicker";
            this.date_check_dateTimePicker.ShowUpDown = true;
            this.date_check_dateTimePicker.Size = new System.Drawing.Size(212, 29);
            this.date_check_dateTimePicker.TabIndex = 2;
            // 
            // check_idLb
            // 
            this.check_idLb.AutoSize = true;
            this.check_idLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_idLb.Location = new System.Drawing.Point(4, 11);
            this.check_idLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.check_idLb.Name = "check_idLb";
            this.check_idLb.Size = new System.Drawing.Size(99, 25);
            this.check_idLb.TabIndex = 1;
            this.check_idLb.Text = "Check ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Checker ID (employee\'s):";
            // 
            // checkidTb
            // 
            this.checkidTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkidTb.Location = new System.Drawing.Point(260, 11);
            this.checkidTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkidTb.Name = "checkidTb";
            this.checkidTb.Size = new System.Drawing.Size(173, 29);
            this.checkidTb.TabIndex = 0;
            // date_checkLb
            // 
            this.date_checkLb.AutoSize = true;
            this.date_checkLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_checkLb.Location = new System.Drawing.Point(4, 60);
            this.date_checkLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date_checkLb.Name = "date_checkLb";
            this.date_checkLb.Size = new System.Drawing.Size(116, 25);
            this.date_checkLb.TabIndex = 1;
            this.date_checkLb.Text = "Date check:";
            // 
            // Check_ID_textBox
            // 
            this.Check_ID_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_ID_textBox.Location = new System.Drawing.Point(260, 110);
            this.Check_ID_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Check_ID_textBox.Name = "Check_ID_textBox";
            this.Check_ID_textBox.Size = new System.Drawing.Size(173, 29);
            this.Check_ID_textBox.TabIndex = 0;
            // 
            // reloadBt
            // 
            this.reloadBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadBt.Location = new System.Drawing.Point(491, 15);
            this.reloadBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reloadBt.Name = "reloadBt";
            this.reloadBt.Size = new System.Drawing.Size(100, 59);
            this.reloadBt.TabIndex = 2;
            this.reloadBt.Text = "Reload";
            this.reloadBt.UseVisualStyleBackColor = true;
            this.reloadBt.Click += new System.EventHandler(this.reloadBt_Click);
            // 
            // addBt
            // 
            this.addBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBt.Location = new System.Drawing.Point(491, 95);
            this.addBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(100, 59);
            this.addBt.TabIndex = 2;
            this.addBt.Text = "Add";
            this.addBt.UseVisualStyleBackColor = true;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // editBt
            // 
            this.editBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBt.Location = new System.Drawing.Point(611, 15);
            this.editBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editBt.Name = "editBt";
            this.editBt.Size = new System.Drawing.Size(100, 59);
            this.editBt.TabIndex = 2;
            this.editBt.Text = "Edit";
            this.editBt.UseVisualStyleBackColor = true;
            this.editBt.Click += new System.EventHandler(this.editBt_Click);
            // 
            // saveBt
            // 
            this.saveBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBt.Location = new System.Drawing.Point(611, 95);
            this.saveBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveBt.Name = "saveBt";
            this.saveBt.Size = new System.Drawing.Size(100, 59);
            this.saveBt.TabIndex = 2;
            this.saveBt.Text = "Save";
            this.saveBt.UseVisualStyleBackColor = true;
            this.saveBt.Click += new System.EventHandler(this.saveBt_Click);
            // 
            // cancelBt
            // 
            this.cancelBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBt.Location = new System.Drawing.Point(731, 15);
            this.cancelBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(100, 59);
            this.cancelBt.TabIndex = 2;
            this.cancelBt.Text = "Cancel";
            this.cancelBt.UseVisualStyleBackColor = true;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // deleteBt
            // 
            this.deleteBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBt.Location = new System.Drawing.Point(731, 95);
            this.deleteBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.Size = new System.Drawing.Size(100, 59);
            this.deleteBt.TabIndex = 2;
            this.deleteBt.Text = "Delete";
            this.deleteBt.UseVisualStyleBackColor = true;
            this.deleteBt.Click += new System.EventHandler(this.deleteBt_Click);
            // 
            // CheckInventoryInfoBt
            // 
            this.CheckInventoryInfoBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInventoryInfoBt.Location = new System.Drawing.Point(491, 254);
            this.CheckInventoryInfoBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckInventoryInfoBt.Name = "CheckInventoryInfoBt";
            this.CheckInventoryInfoBt.Size = new System.Drawing.Size(340, 68);
            this.CheckInventoryInfoBt.TabIndex = 2;
            this.CheckInventoryInfoBt.Text = "Check Inventory Info";
            this.CheckInventoryInfoBt.UseVisualStyleBackColor = true;
            this.CheckInventoryInfoBt.Click += new System.EventHandler(this.CheckInventoryInfoBt_Click);
            // 
            // goBackBt
            // 
            this.goBackBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackBt.Location = new System.Drawing.Point(491, 347);
            this.goBackBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.goBackBt.Name = "goBackBt";
            this.goBackBt.Size = new System.Drawing.Size(340, 68);
            this.goBackBt.TabIndex = 2;
            this.goBackBt.Text = "Go back";
            this.goBackBt.UseVisualStyleBackColor = true;
            this.goBackBt.Click += new System.EventHandler(this.goBackBt_Click);
            // 
            // Inventory_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 430);
            this.Controls.Add(this.deleteBt);
            this.Controls.Add(this.saveBt);
            this.Controls.Add(this.goBackBt);
            this.Controls.Add(this.CheckInventoryInfoBt);
            this.Controls.Add(this.addBt);
            this.Controls.Add(this.cancelBt);
            this.Controls.Add(this.editBt);
            this.Controls.Add(this.reloadBt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InventoryDGV);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Inventory_Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Bill_Interface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView InventoryDGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker date_check_dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label date_checkLb;
        private System.Windows.Forms.TextBox Check_ID_textBox;
        private System.Windows.Forms.Button reloadBt;
        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.Button editBt;
        private System.Windows.Forms.Button saveBt;
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.Button deleteBt;
        private System.Windows.Forms.Button CheckInventoryInfoBt;
        private System.Windows.Forms.Button goBackBt;
        private Coffee_ShopDataSet coffee_ShopDataSet;
        private Coffee_ShopDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecheckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label check_idLb;
        private System.Windows.Forms.TextBox checkidTb;
    }
}

