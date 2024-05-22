using IN451_M2.DatabaseLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IN451_M2
{
    public partial class frmWelcome : Form
    {
        private IN451_M2.BusinessLayer.BusinessLayer businessLayer;
        private List<UserRoleModel> userRoles;
        public frmWelcome()
        {
            InitializeComponent();
        }
        public frmWelcome(List<UserRoleModel> roles, IN451_M2.BusinessLayer.BusinessLayer _businessLayer)
        {
            InitializeComponent();
            businessLayer = _businessLayer;
            userRoles = roles;
            foreach (UserRoleModel role in roles)
            {
                switch (role.RoleName)
                {
                    case "CEORole":
                        EnableCustomersButton();
                        EnableOrdersButton();
                        EnableEmployeesButton();
                        break;
                    case "SalesRole":
                        EnableOrdersButton();
                        EnableCustomersButton();
                        break;
                    case "HRRole":
                        EnableEmployeesButton();
                        break;
                    default:
                        break;
                }
            }
        }
        public void EnableOrdersButton()
        {
            btnOrderData.Enabled = true;
        }
        public void EnableCustomersButton()
        {
            btnCustomerData.Enabled = true;
        }
        public void EnableEmployeesButton()
        {
            btnEmployeeData.Enabled = true;
        }

        private void btnCustomerData_Click(object sender, EventArgs e)
        {
            frmCustomerData customerData = new frmCustomerData(businessLayer, userRoles);
            customerData.Show();
            this.Hide();
        }

        private void btnEmployeeData_Click(object sender, EventArgs e)
        {
            frmEmployeeData employeeData = new frmEmployeeData(businessLayer, userRoles);
            employeeData.Show();
            this.Hide();
        }

        private void btnOrderData_Click(object sender, EventArgs e)
        {
            frmOrderData orderData = new frmOrderData(businessLayer, userRoles);
            orderData.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
