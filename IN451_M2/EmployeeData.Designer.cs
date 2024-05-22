namespace IN451_M2
{
    partial class frmEmployeeData
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
            lblNumberofEmployees = new Label();
            lblNumberCustomersFromBL = new Label();
            lblCustomerInformation = new Label();
            dataGridCustomerData = new DataGridView();
            btnReturnHome = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridCustomerData).BeginInit();
            SuspendLayout();
            // 
            // lblCustomerDataTitle
            // 
            lblCustomerDataTitle.AutoSize = true;
            lblCustomerDataTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerDataTitle.Location = new Point(352, 29);
            lblCustomerDataTitle.Name = "lblCustomerDataTitle";
            lblCustomerDataTitle.Size = new Size(174, 31);
            lblCustomerDataTitle.TabIndex = 0;
            lblCustomerDataTitle.Text = "Employee Data";
            lblCustomerDataTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblCustomerDataTitle.Click += lblCustomerDataTitle_Click;
            // 
            // lblNumberofEmployees
            // 
            lblNumberofEmployees.AutoSize = true;
            lblNumberofEmployees.Location = new Point(62, 69);
            lblNumberofEmployees.Name = "lblNumberofEmployees";
            lblNumberofEmployees.Size = new Size(157, 20);
            lblNumberofEmployees.TabIndex = 1;
            lblNumberofEmployees.Text = "Number of Employees";
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
            lblCustomerInformation.Size = new Size(157, 20);
            lblCustomerInformation.TabIndex = 3;
            lblCustomerInformation.Text = "Employee Information";
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
            // frmEmployeeData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 607);
            Controls.Add(btnReturnHome);
            Controls.Add(dataGridCustomerData);
            Controls.Add(lblCustomerInformation);
            Controls.Add(lblNumberCustomersFromBL);
            Controls.Add(lblNumberofEmployees);
            Controls.Add(lblCustomerDataTitle);
            Name = "frmEmployeeData";
            Text = "Employee Data";
            Load += frmEmployeeData_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridCustomerData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomerDataTitle;
        private Label lblNumberofEmployees;
        private Label lblNumberCustomersFromBL;
        private Label lblCustomerInformation;
        private DataGridView dataGridCustomerData;
        private Button btnReturnHome;
    }
}
