namespace CafeShopDatabase
{
    partial class Supplier
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
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.pl_Input = new System.Windows.Forms.Panel();
            this.txtSupplier_Email = new System.Windows.Forms.TextBox();
            this.txtSupplier_Phone_Number = new System.Windows.Forms.TextBox();
            this.txtSupplier_Address = new System.Windows.Forms.TextBox();
            this.txtSupplier_Name = new System.Windows.Forms.TextBox();
            this.LbEmail = new System.Windows.Forms.Label();
            this.LbPhoneNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LbAddress = new System.Windows.Forms.Label();
            this.LbName = new System.Windows.Forms.Label();
            this.txtSupplier_Id = new System.Windows.Forms.TextBox();
            this.LbSupplierID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.pl_Input.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Location = new System.Drawing.Point(22, 293);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.RowHeadersWidth = 51;
            this.dgvSupplier.RowTemplate.Height = 24;
            this.dgvSupplier.Size = new System.Drawing.Size(738, 278);
            this.dgvSupplier.TabIndex = 53;
            // 
            // btnGoBack
            // 
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.Location = new System.Drawing.Point(617, 601);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(143, 114);
            this.btnGoBack.TabIndex = 52;
            this.btnGoBack.Text = "Go back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(294, 661);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 45);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(291, 601);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 45);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(157, 659);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 45);
            this.btnSave.TabIndex = 49;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(156, 601);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 43);
            this.btnEdit.TabIndex = 47;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(22, 661);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 43);
            this.btnAdd.TabIndex = 46;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(22, 599);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(101, 45);
            this.btnReload.TabIndex = 45;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // pl_Input
            // 
            this.pl_Input.Controls.Add(this.txtSupplier_Email);
            this.pl_Input.Controls.Add(this.txtSupplier_Phone_Number);
            this.pl_Input.Controls.Add(this.txtSupplier_Address);
            this.pl_Input.Controls.Add(this.txtSupplier_Name);
            this.pl_Input.Controls.Add(this.LbEmail);
            this.pl_Input.Controls.Add(this.LbPhoneNumber);
            this.pl_Input.Controls.Add(this.label6);
            this.pl_Input.Controls.Add(this.LbAddress);
            this.pl_Input.Controls.Add(this.LbName);
            this.pl_Input.Controls.Add(this.txtSupplier_Id);
            this.pl_Input.Controls.Add(this.LbSupplierID);
            this.pl_Input.Controls.Add(this.label2);
            this.pl_Input.Location = new System.Drawing.Point(22, 48);
            this.pl_Input.Name = "pl_Input";
            this.pl_Input.Size = new System.Drawing.Size(738, 239);
            this.pl_Input.TabIndex = 44;
            // 
            // txtSupplier_Email
            // 
            this.txtSupplier_Email.Location = new System.Drawing.Point(192, 206);
            this.txtSupplier_Email.Name = "txtSupplier_Email";
            this.txtSupplier_Email.Size = new System.Drawing.Size(484, 22);
            this.txtSupplier_Email.TabIndex = 11;
            // 
            // txtSupplier_Phone_Number
            // 
            this.txtSupplier_Phone_Number.Location = new System.Drawing.Point(192, 155);
            this.txtSupplier_Phone_Number.Name = "txtSupplier_Phone_Number";
            this.txtSupplier_Phone_Number.Size = new System.Drawing.Size(484, 22);
            this.txtSupplier_Phone_Number.TabIndex = 10;
            // 
            // txtSupplier_Address
            // 
            this.txtSupplier_Address.Location = new System.Drawing.Point(192, 107);
            this.txtSupplier_Address.Name = "txtSupplier_Address";
            this.txtSupplier_Address.Size = new System.Drawing.Size(484, 22);
            this.txtSupplier_Address.TabIndex = 9;
            // 
            // txtSupplier_Name
            // 
            this.txtSupplier_Name.Location = new System.Drawing.Point(192, 60);
            this.txtSupplier_Name.Name = "txtSupplier_Name";
            this.txtSupplier_Name.Size = new System.Drawing.Size(484, 22);
            this.txtSupplier_Name.TabIndex = 8;
            // 
            // LbEmail
            // 
            this.LbEmail.AutoSize = true;
            this.LbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmail.Location = new System.Drawing.Point(9, 203);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(65, 25);
            this.LbEmail.TabIndex = 7;
            this.LbEmail.Text = "Email";
            // 
            // LbPhoneNumber
            // 
            this.LbPhoneNumber.AutoSize = true;
            this.LbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPhoneNumber.Location = new System.Drawing.Point(9, 155);
            this.LbPhoneNumber.Name = "LbPhoneNumber";
            this.LbPhoneNumber.Size = new System.Drawing.Size(155, 25);
            this.LbPhoneNumber.TabIndex = 6;
            this.LbPhoneNumber.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 5;
            // 
            // LbAddress
            // 
            this.LbAddress.AutoSize = true;
            this.LbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAddress.Location = new System.Drawing.Point(9, 104);
            this.LbAddress.Name = "LbAddress";
            this.LbAddress.Size = new System.Drawing.Size(92, 25);
            this.LbAddress.TabIndex = 4;
            this.LbAddress.Text = "Address";
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbName.Location = new System.Drawing.Point(4, 60);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(80, 25);
            this.LbName.TabIndex = 3;
            this.LbName.Text = " Name ";
            // 
            // txtSupplier_Id
            // 
            this.txtSupplier_Id.Location = new System.Drawing.Point(192, 9);
            this.txtSupplier_Id.Name = "txtSupplier_Id";
            this.txtSupplier_Id.Size = new System.Drawing.Size(484, 22);
            this.txtSupplier_Id.TabIndex = 2;
            // 
            // LbSupplierID
            // 
            this.LbSupplierID.AutoSize = true;
            this.LbSupplierID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSupplierID.Location = new System.Drawing.Point(4, 9);
            this.LbSupplierID.Name = "LbSupplierID";
            this.LbSupplierID.Size = new System.Drawing.Size(116, 25);
            this.LbSupplierID.TabIndex = 1;
            this.LbSupplierID.Text = "Supplier Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 27);
            this.label1.TabIndex = 43;
            this.label1.Text = "SUPPLIER";
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 725);
            this.Controls.Add(this.dgvSupplier);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.pl_Input);
            this.Controls.Add(this.label1);
            this.Name = "Supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.pl_Input.ResumeLayout(false);
            this.pl_Input.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Panel pl_Input;
        private System.Windows.Forms.TextBox txtSupplier_Email;
        private System.Windows.Forms.TextBox txtSupplier_Phone_Number;
        private System.Windows.Forms.TextBox txtSupplier_Address;
        private System.Windows.Forms.TextBox txtSupplier_Name;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.Label LbPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LbAddress;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.TextBox txtSupplier_Id;
        private System.Windows.Forms.Label LbSupplierID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}