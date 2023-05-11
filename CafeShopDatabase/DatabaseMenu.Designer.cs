namespace CafeShopDatabase
{
    partial class DatabaseMenu
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
            this.DatabaseListBox = new System.Windows.Forms.ListBox();
            this.CoffeeShopLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openBt = new System.Windows.Forms.Button();
            this.logoutBt = new System.Windows.Forms.Button();
            this.helpBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DatabaseListBox
            // 
            this.DatabaseListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseListBox.FormattingEnabled = true;
            this.DatabaseListBox.ItemHeight = 22;
            this.DatabaseListBox.Items.AddRange(new object[] {
            "Bill",
            "Remaining Items",
            "Inventory",
            "Supply purchase",
            "Employee",
            "Supplier",
            "Ingredient"});
            this.DatabaseListBox.Location = new System.Drawing.Point(17, 101);
            this.DatabaseListBox.Name = "DatabaseListBox";
            this.DatabaseListBox.Size = new System.Drawing.Size(200, 180);
            this.DatabaseListBox.TabIndex = 1;
            // 
            // CoffeeShopLb
            // 
            this.CoffeeShopLb.AutoSize = true;
            this.CoffeeShopLb.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CoffeeShopLb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CoffeeShopLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoffeeShopLb.Location = new System.Drawing.Point(118, 9);
            this.CoffeeShopLb.Name = "CoffeeShopLb";
            this.CoffeeShopLb.Size = new System.Drawing.Size(169, 34);
            this.CoffeeShopLb.TabIndex = 2;
            this.CoffeeShopLb.Text = "Coffee shop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Database list:";
            // 
            // openBt
            // 
            this.openBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openBt.Location = new System.Drawing.Point(277, 101);
            this.openBt.Name = "openBt";
            this.openBt.Size = new System.Drawing.Size(98, 44);
            this.openBt.TabIndex = 4;
            this.openBt.Text = "Open";
            this.openBt.UseVisualStyleBackColor = true;
            this.openBt.Click += new System.EventHandler(this.openBt_Click);
            // 
            // logoutBt
            // 
            this.logoutBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBt.Location = new System.Drawing.Point(277, 170);
            this.logoutBt.Name = "logoutBt";
            this.logoutBt.Size = new System.Drawing.Size(98, 44);
            this.logoutBt.TabIndex = 5;
            this.logoutBt.Text = "Log out";
            this.logoutBt.UseVisualStyleBackColor = true;
            this.logoutBt.Click += new System.EventHandler(this.logoutBt_Click);
            // 
            // helpBt
            // 
            this.helpBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBt.Location = new System.Drawing.Point(277, 237);
            this.helpBt.Name = "helpBt";
            this.helpBt.Size = new System.Drawing.Size(98, 44);
            this.helpBt.TabIndex = 6;
            this.helpBt.Text = "Help";
            this.helpBt.UseVisualStyleBackColor = true;
            this.helpBt.Click += new System.EventHandler(this.helpBt_Click);
            // 
            // DatabaseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 293);
            this.Controls.Add(this.helpBt);
            this.Controls.Add(this.logoutBt);
            this.Controls.Add(this.openBt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CoffeeShopLb);
            this.Controls.Add(this.DatabaseListBox);
            this.Name = "DatabaseMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DatabaseListBox;
        private System.Windows.Forms.Label CoffeeShopLb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button openBt;
        private System.Windows.Forms.Button logoutBt;
        private System.Windows.Forms.Button helpBt;
    }
}