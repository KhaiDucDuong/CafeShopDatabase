namespace CafeShopDatabase
{
    partial class item
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
            this.reloadBT = new System.Windows.Forms.Button();
            this.goBackBt = new System.Windows.Forms.Button();
            this.addBT = new System.Windows.Forms.Button();
            this.cancelBT = new System.Windows.Forms.Button();
            this.deleteBT = new System.Windows.Forms.Button();
            this.saveBT = new System.Windows.Forms.Button();
            this.editBT = new System.Windows.Forms.Button();
            this.item_priceLb = new System.Windows.Forms.Label();
            this.item_idTB = new System.Windows.Forms.TextBox();
            this.Item_NameLB = new System.Windows.Forms.Label();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.itemPriceTB = new System.Windows.Forms.TextBox();
            this.itemName_TB = new System.Windows.Forms.TextBox();
            this.Itemlabel = new System.Windows.Forms.Label();
            this.ItemDGV = new System.Windows.Forms.DataGridView();
            this.InputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // reloadBT
            // 
            this.reloadBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadBT.Location = new System.Drawing.Point(486, 11);
            this.reloadBT.Margin = new System.Windows.Forms.Padding(4);
            this.reloadBT.Name = "reloadBT";
            this.reloadBT.Size = new System.Drawing.Size(100, 59);
            this.reloadBT.TabIndex = 44;
            this.reloadBT.Text = "Reload";
            this.reloadBT.UseVisualStyleBackColor = true;
            this.reloadBT.Click += new System.EventHandler(this.reloadBT_Click);
            // 
            // goBackBt
            // 
            this.goBackBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackBt.Location = new System.Drawing.Point(486, 343);
            this.goBackBt.Margin = new System.Windows.Forms.Padding(4);
            this.goBackBt.Name = "goBackBt";
            this.goBackBt.Size = new System.Drawing.Size(340, 68);
            this.goBackBt.TabIndex = 40;
            this.goBackBt.Text = "Go back";
            this.goBackBt.UseVisualStyleBackColor = true;
            this.goBackBt.Click += new System.EventHandler(this.goBackBt_Click);
            // 
            // addBT
            // 
            this.addBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBT.Location = new System.Drawing.Point(486, 91);
            this.addBT.Margin = new System.Windows.Forms.Padding(4);
            this.addBT.Name = "addBT";
            this.addBT.Size = new System.Drawing.Size(100, 59);
            this.addBT.TabIndex = 41;
            this.addBT.Text = "Add";
            this.addBT.UseVisualStyleBackColor = true;
            this.addBT.Click += new System.EventHandler(this.addBT_Click);
            // 
            // cancelBT
            // 
            this.cancelBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBT.Location = new System.Drawing.Point(726, 11);
            this.cancelBT.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBT.Name = "cancelBT";
            this.cancelBT.Size = new System.Drawing.Size(100, 59);
            this.cancelBT.TabIndex = 42;
            this.cancelBT.Text = "Cancel";
            this.cancelBT.UseVisualStyleBackColor = true;
            this.cancelBT.Click += new System.EventHandler(this.cancelBT_Click);
            // 
            // deleteBT
            // 
            this.deleteBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBT.Location = new System.Drawing.Point(726, 91);
            this.deleteBT.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBT.Name = "deleteBT";
            this.deleteBT.Size = new System.Drawing.Size(100, 59);
            this.deleteBT.TabIndex = 37;
            this.deleteBT.Text = "Delete";
            this.deleteBT.UseVisualStyleBackColor = true;
            this.deleteBT.Click += new System.EventHandler(this.deleteBT_Click);
            // 
            // saveBT
            // 
            this.saveBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBT.Location = new System.Drawing.Point(606, 91);
            this.saveBT.Margin = new System.Windows.Forms.Padding(4);
            this.saveBT.Name = "saveBT";
            this.saveBT.Size = new System.Drawing.Size(100, 59);
            this.saveBT.TabIndex = 38;
            this.saveBT.Text = "Save";
            this.saveBT.UseVisualStyleBackColor = true;
            this.saveBT.Click += new System.EventHandler(this.saveBT_Click);
            // 
            // editBT
            // 
            this.editBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBT.Location = new System.Drawing.Point(606, 11);
            this.editBT.Margin = new System.Windows.Forms.Padding(4);
            this.editBT.Name = "editBT";
            this.editBT.Size = new System.Drawing.Size(100, 59);
            this.editBT.TabIndex = 43;
            this.editBT.Text = "Edit";
            this.editBT.UseVisualStyleBackColor = true;
            this.editBT.Click += new System.EventHandler(this.editBT_Click);
            // 
            // item_priceLb
            // 
            this.item_priceLb.AutoSize = true;
            this.item_priceLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_priceLb.Location = new System.Drawing.Point(4, 95);
            this.item_priceLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.item_priceLb.Name = "item_priceLb";
            this.item_priceLb.Size = new System.Drawing.Size(98, 25);
            this.item_priceLb.TabIndex = 1;
            this.item_priceLb.Text = "Item Price";
            // 
            // item_idTB
            // 
            this.item_idTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_idTB.Location = new System.Drawing.Point(214, 11);
            this.item_idTB.Margin = new System.Windows.Forms.Padding(4);
            this.item_idTB.Name = "item_idTB";
            this.item_idTB.Size = new System.Drawing.Size(219, 29);
            this.item_idTB.TabIndex = 0;
            // 
            // Item_NameLB
            // 
            this.Item_NameLB.AutoSize = true;
            this.Item_NameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_NameLB.Location = new System.Drawing.Point(4, 56);
            this.Item_NameLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Item_NameLB.Name = "Item_NameLB";
            this.Item_NameLB.Size = new System.Drawing.Size(112, 25);
            this.Item_NameLB.TabIndex = 1;
            this.Item_NameLB.Text = "Item Name:";
            // 
            // InputPanel
            // 
            this.InputPanel.Controls.Add(this.itemPriceTB);
            this.InputPanel.Controls.Add(this.item_priceLb);
            this.InputPanel.Controls.Add(this.itemName_TB);
            this.InputPanel.Controls.Add(this.Itemlabel);
            this.InputPanel.Controls.Add(this.item_idTB);
            this.InputPanel.Controls.Add(this.Item_NameLB);
            this.InputPanel.Location = new System.Drawing.Point(13, 11);
            this.InputPanel.Margin = new System.Windows.Forms.Padding(4);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(457, 167);
            this.InputPanel.TabIndex = 36;
            // 
            // itemPriceTB
            // 
            this.itemPriceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPriceTB.Location = new System.Drawing.Point(214, 95);
            this.itemPriceTB.Margin = new System.Windows.Forms.Padding(4);
            this.itemPriceTB.Name = "itemPriceTB";
            this.itemPriceTB.Size = new System.Drawing.Size(219, 29);
            this.itemPriceTB.TabIndex = 0;
            // 
            // itemName_TB
            // 
            this.itemName_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName_TB.Location = new System.Drawing.Point(214, 52);
            this.itemName_TB.Margin = new System.Windows.Forms.Padding(4);
            this.itemName_TB.Name = "itemName_TB";
            this.itemName_TB.Size = new System.Drawing.Size(219, 29);
            this.itemName_TB.TabIndex = 0;
            // 
            // Itemlabel
            // 
            this.Itemlabel.AutoSize = true;
            this.Itemlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Itemlabel.Location = new System.Drawing.Point(4, 17);
            this.Itemlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Itemlabel.Name = "Itemlabel";
            this.Itemlabel.Size = new System.Drawing.Size(79, 25);
            this.Itemlabel.TabIndex = 1;
            this.Itemlabel.Text = "Item ID:";
            // 
            // ItemDGV
            // 
            this.ItemDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemDGV.Location = new System.Drawing.Point(13, 186);
            this.ItemDGV.Margin = new System.Windows.Forms.Padding(4);
            this.ItemDGV.Name = "ItemDGV";
            this.ItemDGV.RowHeadersWidth = 51;
            this.ItemDGV.Size = new System.Drawing.Size(457, 224);
            this.ItemDGV.TabIndex = 35;
            this.ItemDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemDGV_CellClick);
            // 
            // item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 423);
            this.Controls.Add(this.reloadBT);
            this.Controls.Add(this.goBackBt);
            this.Controls.Add(this.addBT);
            this.Controls.Add(this.cancelBT);
            this.Controls.Add(this.deleteBT);
            this.Controls.Add(this.saveBT);
            this.Controls.Add(this.editBT);
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(this.ItemDGV);
            this.Name = "item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "item";
            this.Load += new System.EventHandler(this.item_Load);
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reloadBT;
        private System.Windows.Forms.Button goBackBt;
        private System.Windows.Forms.Button addBT;
        private System.Windows.Forms.Button cancelBT;
        private System.Windows.Forms.Button deleteBT;
        private System.Windows.Forms.Button saveBT;
        private System.Windows.Forms.Button editBT;
        private System.Windows.Forms.Label item_priceLb;
        private System.Windows.Forms.TextBox item_idTB;
        private System.Windows.Forms.Label Item_NameLB;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.TextBox itemPriceTB;
        private System.Windows.Forms.TextBox itemName_TB;
        private System.Windows.Forms.Label Itemlabel;
        private System.Windows.Forms.DataGridView ItemDGV;
    }
}