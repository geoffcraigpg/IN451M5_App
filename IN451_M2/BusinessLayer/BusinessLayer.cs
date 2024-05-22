using IN451_M2.DatabaseLayer.Model;
using IN451_M2.DatabaseLayer.Services;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IN451_M2.BusinessLayer
{
    public class BusinessLayer
    {
        private readonly DataAccess _dataAccess;

        public BusinessLayer(string connectionString)
        {
            _dataAccess = new DataAccess(connectionString);
        }

        public int GetCustomerCount()
        {
            return _dataAccess.GetCustomerCount();
        }

        public List<CustomerModel> GetCustomerData()
        {
            return _dataAccess.GetCustomerData();
        }

        public int GetEmployeeCount()
        {
            return _dataAccess.GetEmployeeCount();
        }

        public List<EmployeeModel> GetEmployeeData()
        {
            return _dataAccess.GetEmployeeData();
        }

        public int GetOrderCount()
        {
            return _dataAccess.GetOrderCount();
        }

        public List<OrderModel> GetOrderData()
        {
            return _dataAccess.GetOrderData();
        }

        public bool TestLogin()
        {
            return _dataAccess.TestLogin();
        }
        public List<UserRoleModel> GetUserRoles()
        {
            return _dataAccess.GetUserRoles();
        }
    }
}
