namespace CafeShopDatabase
{
    partial class Inventory_info_Interface
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
            this.deleteBt = new System.Windows.Forms.Button();
            this.saveBt = new System.Windows.Forms.Button();
            this.goBackBt = new System.Windows.Forms.Button();
            this.CheckInventoryBt = new System.Windows.Forms.Button();
            this.addBt = new System.Windows.Forms.Button();
            this.cancelBt = new System.Windows.Forms.Button();
            this.editBt = new System.Windows.Forms.Button();
            this.reloadBt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.quantity_per_unitLb = new System.Windows.Forms.Label();
            this.quantity_per_unitTB = new System.Windows.Forms.TextBox();
            this.ingredient_idLb = new System.Windows.Forms.Label();
            this.Ingredient_id_TB = new System.Windows.Forms.TextBox();
            this.check_idLb = new System.Windows.Forms.Label();
            this.checkidTb = new System.Windows.Forms.TextBox();
            this.InventoryDGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteBt
            // 
            this.deleteBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBt.Location = new System.Drawing.Point(729, 102);
            this.deleteBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.Size = new System.Drawing.Size(100, 59);
            this.deleteBt.TabIndex = 5;
            this.deleteBt.Text = "Delete";
            this.deleteBt.UseVisualStyleBackColor = true;
            this.deleteBt.Click += new System.EventHandler(this.deleteBt_Click);
            // 
            // saveBt
            // 
            this.saveBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBt.Location = new System.Drawing.Point(609, 102);
            this.saveBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveBt.Name = "saveBt";
            this.saveBt.Size = new System.Drawing.Size(100, 59);
            this.saveBt.TabIndex = 6;
            this.saveBt.Text = "Save";
            this.saveBt.UseVisualStyleBackColor = true;
            this.saveBt.Click += new System.EventHandler(this.saveBt_Click);
            // 
            // goBackBt
            // 
            this.goBackBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackBt.Location = new System.Drawing.Point(489, 354);
            this.goBackBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.goBackBt.Name = "goBackBt";
            this.goBackBt.Size = new System.Drawing.Size(340, 68);
            this.goBackBt.TabIndex = 8;
            this.goBackBt.Text = "Go back";
            this.goBackBt.UseVisualStyleBackColor = true;
            this.goBackBt.Click += new System.EventHandler(this.goBackBt_Click);
            // 
            // CheckInventoryBt
            // 
            this.CheckInventoryBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInventoryBt.Location = new System.Drawing.Point(489, 262);
            this.CheckInventoryBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckInventoryBt.Name = "CheckInventoryBt";
            this.CheckInventoryBt.Size = new System.Drawing.Size(340, 68);
            this.CheckInventoryBt.TabIndex = 9;
            this.CheckInventoryBt.Text = "Check Inventory";
            this.CheckInventoryBt.UseVisualStyleBackColor = true;
            this.CheckInventoryBt.Click += new System.EventHandler(this.CheckInventoryBt_Click);
            // 
            // addBt
            // 
            this.addBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBt.Location = new System.Drawing.Point(489, 102);
            this.addBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(100, 59);
            this.addBt.TabIndex = 10;
            this.addBt.Text = "Add";
            this.addBt.UseVisualStyleBackColor = true;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // cancelBt
            // 
            this.cancelBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBt.Location = new System.Drawing.Point(729, 22);
            this.cancelBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(100, 59);
            this.cancelBt.TabIndex = 11;
            this.cancelBt.Text = "Cancel";
            this.cancelBt.UseVisualStyleBackColor = true;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // editBt
            // 
            this.editBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBt.Location = new System.Drawing.Point(609, 22);
            this.editBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editBt.Name = "editBt";
            this.editBt.Size = new System.Drawing.Size(100, 59);
            this.editBt.TabIndex = 12;
            this.editBt.Text = "Edit";
            this.editBt.UseVisualStyleBackColor = true;
            this.editBt.Click += new System.EventHandler(this.editBt_Click);
            // 
            // reloadBt
            // 
            this.reloadBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadBt.Location = new System.Drawing.Point(489, 22);
            this.reloadBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reloadBt.Name = "reloadBt";
            this.reloadBt.Size = new System.Drawing.Size(100, 59);
            this.reloadBt.TabIndex = 13;
            this.reloadBt.Text = "Reload";
            this.reloadBt.UseVisualStyleBackColor = true;
            this.reloadBt.Click += new System.EventHandler(this.reloadBt_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.quantity_per_unitLb);
            this.panel1.Controls.Add(this.quantity_per_unitTB);
            this.panel1.Controls.Add(this.ingredient_idLb);
            this.panel1.Controls.Add(this.Ingredient_id_TB);
            this.panel1.Controls.Add(this.check_idLb);
            this.panel1.Controls.Add(this.checkidTb);
            this.panel1.Location = new System.Drawing.Point(16, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 153);
            this.panel1.TabIndex = 4;
            // 
            // quantity_per_unitLb
            // 
            this.quantity_per_unitLb.AutoSize = true;
            this.quantity_per_unitLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_per_unitLb.Location = new System.Drawing.Point(4, 114);
            this.quantity_per_unitLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantity_per_unitLb.Name = "quantity_per_unitLb";
            this.quantity_per_unitLb.Size = new System.Drawing.Size(163, 25);
            this.quantity_per_unitLb.TabIndex = 1;
            this.quantity_per_unitLb.Text = "Quantity per Unit:";
            // 
            // quantity_per_unitTB
            // 
            this.quantity_per_unitTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_per_unitTB.Location = new System.Drawing.Point(188, 114);
            this.quantity_per_unitTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quantity_per_unitTB.Name = "quantity_per_unitTB";
            this.quantity_per_unitTB.Size = new System.Drawing.Size(245, 29);
            this.quantity_per_unitTB.TabIndex = 0;
            // 
            // ingredient_idLb
            // 
            this.ingredient_idLb.AutoSize = true;
            this.ingredient_idLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredient_idLb.Location = new System.Drawing.Point(4, 66);
            this.ingredient_idLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ingredient_idLb.Name = "ingredient_idLb";
            this.ingredient_idLb.Size = new System.Drawing.Size(128, 25);
            this.ingredient_idLb.TabIndex = 1;
            this.ingredient_idLb.Text = "Ingredient ID:";
            // 
            // Ingredient_id_TB
            // 
            this.Ingredient_id_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingredient_id_TB.Location = new System.Drawing.Point(188, 66);
            this.Ingredient_id_TB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ingredient_id_TB.Name = "Ingredient_id_TB";
            this.Ingredient_id_TB.Size = new System.Drawing.Size(245, 29);
            this.Ingredient_id_TB.TabIndex = 0;
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
            // checkidTb
            // 
            this.checkidTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkidTb.Location = new System.Drawing.Point(188, 11);
            this.checkidTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkidTb.Name = "checkidTb";
            this.checkidTb.Size = new System.Drawing.Size(245, 29);
            this.checkidTb.TabIndex = 0;
            // 
            // InventoryDGV
            // 
            this.InventoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryDGV.Location = new System.Drawing.Point(16, 182);
            this.InventoryDGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InventoryDGV.Name = "InventoryDGV";
            this.InventoryDGV.RowHeadersWidth = 51;
            this.InventoryDGV.Size = new System.Drawing.Size(457, 239);
            this.InventoryDGV.TabIndex = 3;
            // 
            // Inventory_info_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 444);
            this.Controls.Add(this.deleteBt);
            this.Controls.Add(this.saveBt);
            this.Controls.Add(this.goBackBt);
            this.Controls.Add(this.CheckInventoryBt);
            this.Controls.Add(this.addBt);
            this.Controls.Add(this.cancelBt);
            this.Controls.Add(this.editBt);
            this.Controls.Add(this.reloadBt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InventoryDGV);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Inventory_info_Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Info";
            this.Load += new System.EventHandler(this.Inventory_info_Interface_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteBt;
        private System.Windows.Forms.Button saveBt;
        private System.Windows.Forms.Button goBackBt;
        private System.Windows.Forms.Button CheckInventoryBt;
        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.Button editBt;
        private System.Windows.Forms.Button reloadBt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label check_idLb;
        private System.Windows.Forms.TextBox checkidTb;
        private System.Windows.Forms.DataGridView InventoryDGV;
        private System.Windows.Forms.Label quantity_per_unitLb;
        private System.Windows.Forms.TextBox quantity_per_unitTB;
        private System.Windows.Forms.Label ingredient_idLb;
        private System.Windows.Forms.TextBox Ingredient_id_TB;
    }
}