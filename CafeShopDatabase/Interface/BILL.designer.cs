namespace CafeShopDatabase
{
    partial class BILL
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
            this.label1 = new System.Windows.Forms.Label();
            this.pl_Input = new System.Windows.Forms.Panel();
            this.dtpBill_Created_At = new System.Windows.Forms.DateTimePicker();
            this.Lb_CreatedAt = new System.Windows.Forms.Label();
            this.txtBill_Id = new System.Windows.Forms.TextBox();
            this.Lb_Bill_ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnOpenBillInfo = new System.Windows.Forms.Button();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.pl_Input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "BILL";
            // 
            // pl_Input
            // 
            this.pl_Input.Controls.Add(this.dtpBill_Created_At);
            this.pl_Input.Controls.Add(this.Lb_CreatedAt);
            this.pl_Input.Controls.Add(this.txtBill_Id);
            this.pl_Input.Controls.Add(this.Lb_Bill_ID);
            this.pl_Input.Controls.Add(this.label2);
            this.pl_Input.Location = new System.Drawing.Point(12, 48);
            this.pl_Input.Name = "pl_Input";
            this.pl_Input.Size = new System.Drawing.Size(716, 112);
            this.pl_Input.TabIndex = 1;
            // 
            // dtpBill_Created_At
            // 
            this.dtpBill_Created_At.CustomFormat = "hh:mm:ss  dd/MM/yyyy";
            this.dtpBill_Created_At.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBill_Created_At.Location = new System.Drawing.Point(192, 72);
            this.dtpBill_Created_At.MinDate = new System.DateTime(2023, 4, 5, 0, 0, 0, 0);
            this.dtpBill_Created_At.Name = "dtpBill_Created_At";
            this.dtpBill_Created_At.RightToLeftLayout = true;
            this.dtpBill_Created_At.ShowUpDown = true;
            this.dtpBill_Created_At.Size = new System.Drawing.Size(251, 22);
            this.dtpBill_Created_At.TabIndex = 5;
            this.dtpBill_Created_At.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Lb_CreatedAt
            // 
            this.Lb_CreatedAt.AutoSize = true;
            this.Lb_CreatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_CreatedAt.Location = new System.Drawing.Point(19, 69);
            this.Lb_CreatedAt.Name = "Lb_CreatedAt";
            this.Lb_CreatedAt.Size = new System.Drawing.Size(116, 25);
            this.Lb_CreatedAt.TabIndex = 4;
            this.Lb_CreatedAt.Text = "Created At";
            this.Lb_CreatedAt.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtBill_Id
            // 
            this.txtBill_Id.Location = new System.Drawing.Point(192, 13);
            this.txtBill_Id.Name = "txtBill_Id";
            this.txtBill_Id.Size = new System.Drawing.Size(340, 22);
            this.txtBill_Id.TabIndex = 2;
            this.txtBill_Id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Lb_Bill_ID
            // 
            this.Lb_Bill_ID.AutoSize = true;
            this.Lb_Bill_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Bill_ID.Location = new System.Drawing.Point(19, 13);
            this.Lb_Bill_ID.Name = "Lb_Bill_ID";
            this.Lb_Bill_ID.Size = new System.Drawing.Size(65, 25);
            this.Lb_Bill_ID.TabIndex = 1;
            this.Lb_Bill_ID.Text = "Bill Id";
            this.Lb_Bill_ID.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 0;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(291, 514);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 45);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(291, 449);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 45);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(146, 514);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 45);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnGoBack
            // 
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.Location = new System.Drawing.Point(599, 449);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(129, 114);
            this.btnGoBack.TabIndex = 26;
            this.btnGoBack.Text = "Go back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(145, 449);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 43);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(13, 516);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 43);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(12, 449);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(101, 45);
            this.btnReload.TabIndex = 23;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // btnOpenBillInfo
            // 
            this.btnOpenBillInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenBillInfo.Location = new System.Drawing.Point(426, 449);
            this.btnOpenBillInfo.Name = "btnOpenBillInfo";
            this.btnOpenBillInfo.Size = new System.Drawing.Size(143, 114);
            this.btnOpenBillInfo.TabIndex = 30;
            this.btnOpenBillInfo.Text = "Open Bill Info";
            this.btnOpenBillInfo.UseVisualStyleBackColor = true;
            this.btnOpenBillInfo.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // dgvBill
            // 
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(13, 184);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.Height = 24;
            this.dgvBill.Size = new System.Drawing.Size(715, 234);
            this.dgvBill.TabIndex = 31;
            this.dgvBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BILL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 593);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.btnOpenBillInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.pl_Input);
            this.Controls.Add(this.label1);
            this.Name = "BILL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BILL";
            this.pl_Input.ResumeLayout(false);
            this.pl_Input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pl_Input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lb_Bill_ID;
        private System.Windows.Forms.TextBox txtBill_Id;
        private System.Windows.Forms.Label Lb_CreatedAt;
        private System.Windows.Forms.DateTimePicker dtpBill_Created_At;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnOpenBillInfo;
        private System.Windows.Forms.DataGridView dgvBill;
    }
}