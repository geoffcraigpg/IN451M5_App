using IN451_M2.DatabaseLayer.Model;
using System;
using System.Windows.Forms;

namespace IN451_M2
{
    public partial class frmCustomerData : Form
    {
        private IN451_M2.BusinessLayer.BusinessLayer _businessLayer;
        private List<UserRoleModel> _userRoles;
        public frmCustomerData(IN451_M2.BusinessLayer.BusinessLayer businessLayer, List<UserRoleModel> userRoles)
        {
            InitializeComponent();
            _businessLayer = businessLayer;
            _userRoles = userRoles;
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

        private void btnReturnHome_Click(object sender, EventArgs e)
        {
            frmWelcome frmWelcome = new frmWelcome(_userRoles, _businessLayer);
            frmWelcome.Show();
            this.Hide();
        }
    }
}
