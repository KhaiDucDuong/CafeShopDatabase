namespace CafeShopDatabase
{
    partial class Ingredient
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
            this.unitBT = new System.Windows.Forms.Label();
            this.ingredient_idTB = new System.Windows.Forms.TextBox();
            this.Ingredient_NameLB = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.unitTB = new System.Windows.Forms.TextBox();
            this.ingredient_id_TB = new System.Windows.Forms.TextBox();
            this.IngredientID_label = new System.Windows.Forms.Label();
            this.InventoryDGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // reloadBT
            // 
            this.reloadBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadBT.Location = new System.Drawing.Point(486, 12);
            this.reloadBT.Margin = new System.Windows.Forms.Padding(4);
            this.reloadBT.Name = "reloadBT";
            this.reloadBT.Size = new System.Drawing.Size(100, 59);
            this.reloadBT.TabIndex = 53;
            this.reloadBT.Text = "Reload";
            this.reloadBT.UseVisualStyleBackColor = true;
            this.reloadBT.Click += new System.EventHandler(this.reloadBT_Click);
            // 
            // goBackBt
            // 
            this.goBackBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackBt.Location = new System.Drawing.Point(486, 344);
            this.goBackBt.Margin = new System.Windows.Forms.Padding(4);
            this.goBackBt.Name = "goBackBt";
            this.goBackBt.Size = new System.Drawing.Size(340, 68);
            this.goBackBt.TabIndex = 49;
            this.goBackBt.Text = "Go back";
            this.goBackBt.UseVisualStyleBackColor = true;
            this.goBackBt.Click += new System.EventHandler(this.goBackBt_Click);
            // 
            // addBT
            // 
            this.addBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBT.Location = new System.Drawing.Point(486, 92);
            this.addBT.Margin = new System.Windows.Forms.Padding(4);
            this.addBT.Name = "addBT";
            this.addBT.Size = new System.Drawing.Size(100, 59);
            this.addBT.TabIndex = 50;
            this.addBT.Text = "Add";
            this.addBT.UseVisualStyleBackColor = true;
            this.addBT.Click += new System.EventHandler(this.addBT_Click);
            // 
            // cancelBT
            // 
            this.cancelBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBT.Location = new System.Drawing.Point(726, 12);
            this.cancelBT.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBT.Name = "cancelBT";
            this.cancelBT.Size = new System.Drawing.Size(100, 59);
            this.cancelBT.TabIndex = 51;
            this.cancelBT.Text = "Cancel";
            this.cancelBT.UseVisualStyleBackColor = true;
            this.cancelBT.Click += new System.EventHandler(this.cancelBT_Click);
            // 
            // deleteBT
            // 
            this.deleteBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBT.Location = new System.Drawing.Point(726, 92);
            this.deleteBT.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBT.Name = "deleteBT";
            this.deleteBT.Size = new System.Drawing.Size(100, 59);
            this.deleteBT.TabIndex = 47;
            this.deleteBT.Text = "Delete";
            this.deleteBT.UseVisualStyleBackColor = true;
            this.deleteBT.Click += new System.EventHandler(this.deleteBT_Click);
            // 
            // saveBT
            // 
            this.saveBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBT.Location = new System.Drawing.Point(606, 92);
            this.saveBT.Margin = new System.Windows.Forms.Padding(4);
            this.saveBT.Name = "saveBT";
            this.saveBT.Size = new System.Drawing.Size(100, 59);
            this.saveBT.TabIndex = 48;
            this.saveBT.Text = "Save";
            this.saveBT.UseVisualStyleBackColor = true;
            this.saveBT.Click += new System.EventHandler(this.saveBT_Click);
            // 
            // editBT
            // 
            this.editBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBT.Location = new System.Drawing.Point(606, 12);
            this.editBT.Margin = new System.Windows.Forms.Padding(4);
            this.editBT.Name = "editBT";
            this.editBT.Size = new System.Drawing.Size(100, 59);
            this.editBT.TabIndex = 52;
            this.editBT.Text = "Edit";
            this.editBT.UseVisualStyleBackColor = true;
            this.editBT.Click += new System.EventHandler(this.editBT_Click);
            // 
            // unitBT
            // 
            this.unitBT.AutoSize = true;
            this.unitBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitBT.Location = new System.Drawing.Point(4, 95);
            this.unitBT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitBT.Name = "unitBT";
            this.unitBT.Size = new System.Drawing.Size(57, 25);
            this.unitBT.TabIndex = 1;
            this.unitBT.Text = "Unit :";
            // 
            // ingredient_idTB
            // 
            this.ingredient_idTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredient_idTB.Location = new System.Drawing.Point(214, 11);
            this.ingredient_idTB.Margin = new System.Windows.Forms.Padding(4);
            this.ingredient_idTB.Name = "ingredient_idTB";
            this.ingredient_idTB.Size = new System.Drawing.Size(219, 29);
            this.ingredient_idTB.TabIndex = 0;
            // 
            // Ingredient_NameLB
            // 
            this.Ingredient_NameLB.AutoSize = true;
            this.Ingredient_NameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingredient_NameLB.Location = new System.Drawing.Point(4, 56);
            this.Ingredient_NameLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ingredient_NameLB.Name = "Ingredient_NameLB";
            this.Ingredient_NameLB.Size = new System.Drawing.Size(161, 25);
            this.Ingredient_NameLB.TabIndex = 1;
            this.Ingredient_NameLB.Text = "Ingredient Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.unitTB);
            this.panel1.Controls.Add(this.unitBT);
            this.panel1.Controls.Add(this.ingredient_id_TB);
            this.panel1.Controls.Add(this.IngredientID_label);
            this.panel1.Controls.Add(this.ingredient_idTB);
            this.panel1.Controls.Add(this.Ingredient_NameLB);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 167);
            this.panel1.TabIndex = 46;
            // 
            // unitTB
            // 
            this.unitTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitTB.Location = new System.Drawing.Point(214, 95);
            this.unitTB.Margin = new System.Windows.Forms.Padding(4);
            this.unitTB.Name = "unitTB";
            this.unitTB.Size = new System.Drawing.Size(219, 29);
            this.unitTB.TabIndex = 0;
            // 
            // ingredient_id_TB
            // 
            this.ingredient_id_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredient_id_TB.Location = new System.Drawing.Point(214, 52);
            this.ingredient_id_TB.Margin = new System.Windows.Forms.Padding(4);
            this.ingredient_id_TB.Name = "ingredient_id_TB";
            this.ingredient_id_TB.Size = new System.Drawing.Size(219, 29);
            this.ingredient_id_TB.TabIndex = 0;
            // 
            // IngredientID_label
            // 
            this.IngredientID_label.AutoSize = true;
            this.IngredientID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientID_label.Location = new System.Drawing.Point(4, 17);
            this.IngredientID_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IngredientID_label.Name = "IngredientID_label";
            this.IngredientID_label.Size = new System.Drawing.Size(128, 25);
            this.IngredientID_label.TabIndex = 1;
            this.IngredientID_label.Text = "Ingredient ID:";
            // 
            // InventoryDGV
            // 
            this.InventoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryDGV.Location = new System.Drawing.Point(13, 187);
            this.InventoryDGV.Margin = new System.Windows.Forms.Padding(4);
            this.InventoryDGV.Name = "InventoryDGV";
            this.InventoryDGV.RowHeadersWidth = 51;
            this.InventoryDGV.Size = new System.Drawing.Size(457, 224);
            this.InventoryDGV.TabIndex = 45;
            // 
            // Ingredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 429);
            this.Controls.Add(this.reloadBT);
            this.Controls.Add(this.goBackBt);
            this.Controls.Add(this.addBT);
            this.Controls.Add(this.cancelBT);
            this.Controls.Add(this.deleteBT);
            this.Controls.Add(this.saveBT);
            this.Controls.Add(this.editBT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InventoryDGV);
            this.Name = "Ingredient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingredient";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDGV)).EndInit();
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
        private System.Windows.Forms.Label unitBT;
        private System.Windows.Forms.TextBox ingredient_idTB;
        private System.Windows.Forms.Label Ingredient_NameLB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox unitTB;
        private System.Windows.Forms.TextBox ingredient_id_TB;
        private System.Windows.Forms.Label IngredientID_label;
        private System.Windows.Forms.DataGridView InventoryDGV;
    }
}