namespace CafeShopDatabase
{
    partial class RealTime_Inventory_Interface
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
            this.checkInventoryInfoBt = new System.Windows.Forms.Button();
            this.goBackBt = new System.Windows.Forms.Button();
            this.CheckInventoryBt = new System.Windows.Forms.Button();
            this.RealTimeInventoryDGV = new System.Windows.Forms.DataGridView();
            this.reloadBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RealTimeInventoryDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // checkInventoryInfoBt
            // 
            this.checkInventoryInfoBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInventoryInfoBt.Location = new System.Drawing.Point(270, 150);
            this.checkInventoryInfoBt.Name = "checkInventoryInfoBt";
            this.checkInventoryInfoBt.Size = new System.Drawing.Size(255, 55);
            this.checkInventoryInfoBt.TabIndex = 18;
            this.checkInventoryInfoBt.Text = "Check Inventory Info";
            this.checkInventoryInfoBt.UseVisualStyleBackColor = true;
            this.checkInventoryInfoBt.Click += new System.EventHandler(this.checkInventoryInfoBt_Click);
            // 
            // goBackBt
            // 
            this.goBackBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackBt.Location = new System.Drawing.Point(270, 220);
            this.goBackBt.Name = "goBackBt";
            this.goBackBt.Size = new System.Drawing.Size(255, 55);
            this.goBackBt.TabIndex = 19;
            this.goBackBt.Text = "Go back";
            this.goBackBt.UseVisualStyleBackColor = true;
            this.goBackBt.Click += new System.EventHandler(this.goBackBt_Click);
            // 
            // CheckInventoryBt
            // 
            this.CheckInventoryBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInventoryBt.Location = new System.Drawing.Point(270, 80);
            this.CheckInventoryBt.Name = "CheckInventoryBt";
            this.CheckInventoryBt.Size = new System.Drawing.Size(255, 55);
            this.CheckInventoryBt.TabIndex = 20;
            this.CheckInventoryBt.Text = "Check Inventory";
            this.CheckInventoryBt.UseVisualStyleBackColor = true;
            this.CheckInventoryBt.Click += new System.EventHandler(this.CheckInventoryBt_Click);
            // 
            // RealTimeInventoryDGV
            // 
            this.RealTimeInventoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RealTimeInventoryDGV.Location = new System.Drawing.Point(12, 10);
            this.RealTimeInventoryDGV.Name = "RealTimeInventoryDGV";
            this.RealTimeInventoryDGV.Size = new System.Drawing.Size(243, 265);
            this.RealTimeInventoryDGV.TabIndex = 14;
            // 
            // reloadBt
            // 
            this.reloadBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadBt.Location = new System.Drawing.Point(270, 10);
            this.reloadBt.Name = "reloadBt";
            this.reloadBt.Size = new System.Drawing.Size(255, 55);
            this.reloadBt.TabIndex = 20;
            this.reloadBt.Text = "Reload";
            this.reloadBt.UseVisualStyleBackColor = true;
            this.reloadBt.Click += new System.EventHandler(this.reloadBt_Click);
            // 
            // RealTime_Inventory_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 285);
            this.Controls.Add(this.checkInventoryInfoBt);
            this.Controls.Add(this.goBackBt);
            this.Controls.Add(this.reloadBt);
            this.Controls.Add(this.CheckInventoryBt);
            this.Controls.Add(this.RealTimeInventoryDGV);
            this.Name = "RealTime_Inventory_Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Real time Inventory";
            this.Load += new System.EventHandler(this.RealTime_Inventory_Interface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RealTimeInventoryDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button checkInventoryInfoBt;
        private System.Windows.Forms.Button goBackBt;
        private System.Windows.Forms.Button CheckInventoryBt;
        private System.Windows.Forms.DataGridView RealTimeInventoryDGV;
        private System.Windows.Forms.Button reloadBt;
    }
}