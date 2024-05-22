using System;
using System.Windows.Forms;

namespace IN451_M2
{
    public partial class frmCustomerData : Form
    {
        private IN451_M2.BusinessLayer.BusinessLayer _businessLayer;
        public frmCustomerData()
        {
            InitializeComponent();
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=Northwind;Trusted_Connection=true;TrustServerCertificate=True;";
            _businessLayer = new BusinessLayer.BusinessLayer(connectionString);
            InitializeData();
        }

        private void frmCustomerData_Load(object sender, EventArgs e)
        {

        }

        private void InitializeData()
        {
            var customers = _businessLayer.GetCustomerData();
            dataGridCustomerData.DataSource = customers;
            int numberOfCustomers = _businessLayer.GetCustomerCount();
            lblNumberCustomersFromBL.Text = numberOfCustomers.ToString();
        }
    }
}
