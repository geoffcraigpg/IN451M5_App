namespace IN451_M2
{
    partial class frmCustomerData
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCustomerDataTitle = new Label();
            lblNumberofCustomers = new Label();
            lblNumberCustomersFromBL = new Label();
            lblCustomerInformation = new Label();
            dataGridCustomerData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridCustomerData).BeginInit();
            SuspendLayout();
            // 
            // lblCustomerDataTitle
            // 
            lblCustomerDataTitle.AutoSize = true;
            lblCustomerDataTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerDataTitle.Location = new Point(352, 29);
            lblCustomerDataTitle.Name = "lblCustomerDataTitle";
            lblCustomerDataTitle.Size = new Size(173, 31);
            lblCustomerDataTitle.TabIndex = 0;
            lblCustomerDataTitle.Text = "Customer Data";
            lblCustomerDataTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNumberofCustomers
            // 
            lblNumberofCustomers.AutoSize = true;
            lblNumberofCustomers.Location = new Point(62, 69);
            lblNumberofCustomers.Name = "lblNumberofCustomers";
            lblNumberofCustomers.Size = new Size(154, 20);
            lblNumberofCustomers.TabIndex = 1;
            lblNumberofCustomers.Text = "Number of Customers";
            // 
            // lblNumberCustomersFromBL
            // 
            lblNumberCustomersFromBL.AutoSize = true;
            lblNumberCustomersFromBL.Location = new Point(222, 69);
            lblNumberCustomersFromBL.Name = "lblNumberCustomersFromBL";
            lblNumberCustomersFromBL.Size = new Size(92, 20);
            lblNumberCustomersFromBL.TabIndex = 2;
            lblNumberCustomersFromBL.Text = "LoadFromBL";
            // 
            // lblCustomerInformation
            // 
            lblCustomerInformation.AutoSize = true;
            lblCustomerInformation.Location = new Point(62, 107);
            lblCustomerInformation.Name = "lblCustomerInformation";
            lblCustomerInformation.Size = new Size(154, 20);
            lblCustomerInformation.TabIndex = 3;
            lblCustomerInformation.Text = "Customer Information";
            // 
            // dataGridCustomerData
            // 
            dataGridCustomerData.AllowUserToAddRows = false;
            dataGridCustomerData.AllowUserToDeleteRows = false;
            dataGridCustomerData.AllowUserToOrderColumns = true;
            dataGridCustomerData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCustomerData.Location = new Point(67, 141);
            dataGridCustomerData.Name = "dataGridCustomerData";
            dataGridCustomerData.ReadOnly = true;
            dataGridCustomerData.RowHeadersWidth = 51;
            dataGridCustomerData.Size = new Size(796, 430);
            dataGridCustomerData.TabIndex = 4;
            // 
            // frmCustomerData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 607);
            Controls.Add(dataGridCustomerData);
            Controls.Add(lblCustomerInformation);
            Controls.Add(lblNumberCustomersFromBL);
            Controls.Add(lblNumberofCustomers);
            Controls.Add(lblCustomerDataTitle);
            Name = "frmCustomerData";
            Text = "Customer Data";
            Load += frmCustomerData_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridCustomerData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomerDataTitle;
        private Label lblNumberofCustomers;
        private Label lblNumberCustomersFromBL;
        private Label lblCustomerInformation;
        private DataGridView dataGridCustomerData;
    }
}
