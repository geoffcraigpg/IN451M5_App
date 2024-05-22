namespace IN451_M2
{
    partial class frmWelcome
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
            lblWelcomeBanner = new Label();
            btnEmployeeData = new Button();
            btnCustomerData = new Button();
            btnOrderData = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblWelcomeBanner
            // 
            lblWelcomeBanner.AutoSize = true;
            lblWelcomeBanner.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeBanner.Location = new Point(257, 39);
            lblWelcomeBanner.Name = "lblWelcomeBanner";
            lblWelcomeBanner.Size = new Size(274, 28);
            lblWelcomeBanner.TabIndex = 0;
            lblWelcomeBanner.Text = "Click a Button to View Data";
            // 
            // btnEmployeeData
            // 
            btnEmployeeData.Enabled = false;
            btnEmployeeData.Location = new Point(301, 110);
            btnEmployeeData.Name = "btnEmployeeData";
            btnEmployeeData.Size = new Size(160, 29);
            btnEmployeeData.TabIndex = 1;
            btnEmployeeData.Text = "Employee Data";
            btnEmployeeData.UseVisualStyleBackColor = true;
            btnEmployeeData.Click += btnEmployeeData_Click;
            // 
            // btnCustomerData
            // 
            btnCustomerData.Enabled = false;
            btnCustomerData.Location = new Point(301, 175);
            btnCustomerData.Name = "btnCustomerData";
            btnCustomerData.Size = new Size(160, 29);
            btnCustomerData.TabIndex = 2;
            btnCustomerData.Text = "Customer Data";
            btnCustomerData.UseVisualStyleBackColor = true;
            btnCustomerData.Click += btnCustomerData_Click;
            // 
            // btnOrderData
            // 
            btnOrderData.Enabled = false;
            btnOrderData.Location = new Point(301, 240);
            btnOrderData.Name = "btnOrderData";
            btnOrderData.Size = new Size(160, 29);
            btnOrderData.TabIndex = 3;
            btnOrderData.Text = "Order Data";
            btnOrderData.UseVisualStyleBackColor = true;
            btnOrderData.Click += btnOrderData_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(301, 293);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(160, 33);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmWelcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnOrderData);
            Controls.Add(btnCustomerData);
            Controls.Add(btnEmployeeData);
            Controls.Add(lblWelcomeBanner);
            Name = "frmWelcome";
            Text = "Welcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcomeBanner;
        private Button btnEmployeeData;
        private Button btnCustomerData;
        private Button btnOrderData;
        private Button btnExit;
    }
}