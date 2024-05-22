namespace IN451_M2
{
    partial class frmOrderData
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
            lblOrderDataTitle = new Label();
            lblNumberofOrders = new Label();
            lblNumberCustomersFromBL = new Label();
            lblOrderInformation = new Label();
            dataGridCustomerData = new DataGridView();
            btnReturnHome = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridCustomerData).BeginInit();
            SuspendLayout();
            // 
            // lblOrderDataTitle
            // 
            lblOrderDataTitle.AutoSize = true;
            lblOrderDataTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderDataTitle.Location = new Point(352, 29);
            lblOrderDataTitle.Name = "lblOrderDataTitle";
            lblOrderDataTitle.Size = new Size(131, 31);
            lblOrderDataTitle.TabIndex = 0;
            lblOrderDataTitle.Text = "Order Data";
            lblOrderDataTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNumberofOrders
            // 
            lblNumberofOrders.AutoSize = true;
            lblNumberofOrders.Location = new Point(62, 69);
            lblNumberofOrders.Name = "lblNumberofOrders";
            lblNumberofOrders.Size = new Size(129, 20);
            lblNumberofOrders.TabIndex = 1;
            lblNumberofOrders.Text = "Number of Orders";
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
            // lblOrderInformation
            // 
            lblOrderInformation.AutoSize = true;
            lblOrderInformation.Location = new Point(62, 107);
            lblOrderInformation.Name = "lblOrderInformation";
            lblOrderInformation.Size = new Size(129, 20);
            lblOrderInformation.TabIndex = 3;
            lblOrderInformation.Text = "Order Information";
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
            // btnReturnHome
            // 
            btnReturnHome.Location = new Point(739, 80);
            btnReturnHome.Name = "btnReturnHome";
            btnReturnHome.Size = new Size(124, 29);
            btnReturnHome.TabIndex = 5;
            btnReturnHome.Text = "Return to Home";
            btnReturnHome.UseVisualStyleBackColor = true;
            btnReturnHome.Click += btnReturnHome_Click;
            // 
            // frmOrderData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 607);
            Controls.Add(btnReturnHome);
            Controls.Add(dataGridCustomerData);
            Controls.Add(lblOrderInformation);
            Controls.Add(lblNumberCustomersFromBL);
            Controls.Add(lblNumberofOrders);
            Controls.Add(lblOrderDataTitle);
            Name = "frmOrderData";
            Text = "Employee Data";
            Load += frmEmployeeData_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridCustomerData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrderDataTitle;
        private Label lblNumberofOrders;
        private Label lblNumberCustomersFromBL;
        private Label lblOrderInformation;
        private DataGridView dataGridCustomerData;
        private Button btnReturnHome;
    }
}
