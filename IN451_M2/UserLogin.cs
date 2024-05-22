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
    public partial class frmUserLogin : Form
    {
        private IN451_M2.BusinessLayer.BusinessLayer _businessLayer;
        public frmUserLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = $"Server=localhost\\SQLEXPRESS;Database=Northwind;User Id={txtUsername.Text};Password={txtPassword.Text};TrustServerCertificate=True";
            
            _businessLayer = new BusinessLayer.BusinessLayer(connectionString);
            if(!_businessLayer.TestLogin())
            {
                MessageBox.Show("Invalid Username or Password, please try again.", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<UserRoleModel> roles = _businessLayer.GetUserRoles();
            if(roles.Count == 0 )
            {
                MessageBox.Show("You do not have permission to the database, please contact support.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            frmWelcome welcomeForm = new frmWelcome(roles, _businessLayer);
            welcomeForm.Show();
            this.Hide();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            UpdateLoginButton();
        }


        private void UpdateLoginButton()
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                btnLogin.Enabled = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            UpdateLoginButton();
        }
    }
}
