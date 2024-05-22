using IN451_M2.DatabaseLayer.Model;
using System;
using System.Windows.Forms;

namespace IN451_M2
{
    public partial class frmOrderData : Form
    {
        private IN451_M2.BusinessLayer.BusinessLayer _businessLayer;
        private List<UserRoleModel> _userRoles;
        public frmOrderData(IN451_M2.BusinessLayer.BusinessLayer businessLayer, List<UserRoleModel> userRoles)
        {
            InitializeComponent();
            _businessLayer = businessLayer;
            _userRoles = userRoles;
            InitializeData();
        }

        private void frmEmployeeData_Load(object sender, EventArgs e)
        {

        }

        private void InitializeData()
        {
            var orders = _businessLayer.GetOrderData();
            dataGridCustomerData.DataSource = orders;
            int numberOfOrders = _businessLayer.GetOrderCount();
            lblNumberCustomersFromBL.Text = numberOfOrders.ToString();
        }

        private void btnReturnHome_Click(object sender, EventArgs e)
        {
            frmWelcome frmWelcome = new frmWelcome(_userRoles, _businessLayer);
            frmWelcome.Show();
            this.Hide();
        }
    }
}
