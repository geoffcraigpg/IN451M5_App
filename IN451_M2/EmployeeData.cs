using IN451_M2.DatabaseLayer.Model;
using System;
using System.Windows.Forms;

namespace IN451_M2
{
    public partial class frmEmployeeData : Form
    {
        private IN451_M2.BusinessLayer.BusinessLayer _businessLayer;
        private List<UserRoleModel> _userRoles;
        public frmEmployeeData(IN451_M2.BusinessLayer.BusinessLayer businessLayer, List<UserRoleModel> userRoles)
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
            var employees = _businessLayer.GetEmployeeData();
            dataGridCustomerData.DataSource = employees;
            int numberOfEmployees = _businessLayer.GetEmployeeCount();
            lblNumberCustomersFromBL.Text = numberOfEmployees.ToString();
        }

        private void btnReturnHome_Click(object sender, EventArgs e)
        {
            frmWelcome frmWelcome = new frmWelcome(_userRoles, _businessLayer);
            frmWelcome.Show();
            this.Hide();
        }

        private void lblCustomerDataTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
