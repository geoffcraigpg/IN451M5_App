using IN451_M2.DatabaseLayer.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IN451_M2.DatabaseLayer.Services
{
    public class DataAccess
    {
        public readonly string _connectionString;

        public DataAccess(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int GetCustomerCount()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("spGetCustomerCount", cn)) 
                    { 
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cn.Open();

                        int customerCount = Convert.ToInt32(cmd.ExecuteScalar());

                        return customerCount;
                    
                    }
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public List<CustomerModel> GetCustomerData()
        {
            List<CustomerModel> customers = new List<CustomerModel>();
            try
            {
                using (SqlConnection cn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("spListCustomers", cn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read()) 
                            { 
                                customers.Add(new CustomerModel
                                {
                                    Address = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : "",
                                    City = reader["City"] != DBNull.Value ? reader["City"].ToString() : "",
                                    CompanyName = reader["CompanyName"].ToString(),
                                    ContactName = reader["ContactName"] != DBNull.Value ? reader["ContactName"].ToString() : "",
                                    ContactTitle = reader["ContactTitle"] != DBNull.Value ? reader["ContactTitle"].ToString() : "",
                                    Country = reader["Country"] != DBNull.Value ? reader["Country"].ToString() : "",
                                    Fax = reader["Fax"] != DBNull.Value ? reader["Fax"].ToString() : "",
                                    Phone = reader["Phone"] != DBNull.Value ? reader["Phone"].ToString() : "",
                                    PostalCode = reader["PostalCode"] != DBNull.Value ? reader["PostalCode"].ToString() : "",
                                    Region = reader["Region"] != DBNull.Value ? reader["Region"].ToString() : ""

                                });
                            }
                        }
                    }
                }
                return customers;
            }
            catch (Exception)
            {
                return new List<CustomerModel>();
            }
        }

        public bool TestLogin()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(_connectionString))
                {
                    cn.Open();
                    cn.Close();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<UserRoleModel> GetUserRoles()
        {
            List<UserRoleModel> userRoles = new List<UserRoleModel>();
            const string userRoleQuery = @"SELECT 
    r.name AS RoleName
FROM sys.database_role_members drm
JOIN sys.database_principals r ON drm.role_principal_id = r.principal_id
JOIN sys.database_principals u ON drm.member_principal_id = u.principal_id
WHERE u.name = USER_NAME();";
            try
            {
                using (SqlConnection cn = new SqlConnection(_connectionString))
                {
                    SqlCommand cmd = new SqlCommand(userRoleQuery, cn);
                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        userRoles.Add(new UserRoleModel
                        {
                            RoleName = reader["RoleName"].ToString()
                        });
                    }
                    reader.Close();
                }
                return userRoles;
            }
            catch (Exception)
            {
                return new List<UserRoleModel>();
            }         
        }

        public int GetEmployeeCount()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("spGetEmployeeCount", cn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cn.Open();

                        int customerCount = Convert.ToInt32(cmd.ExecuteScalar());

                        return customerCount;

                    }
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public List<EmployeeModel> GetEmployeeData()
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();
            try
            {
                using (SqlConnection cn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("spListEmployees", cn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                employees.Add(new EmployeeModel
                                {
                                    BirthDate = reader["BirthDate"] != DBNull.Value ? (DateTime)reader["BirthDate"] : new DateTime(1900, 1, 1),
                                    Extension = reader["Extension"] != DBNull.Value ? reader["Extension"].ToString() : "",
                                    FirstName = reader["FirstName"].ToString(),
                                    HireDate = reader["HireDate"] != DBNull.Value ? (DateTime)reader["BirthDate"] : new DateTime(1900, 1, 1),
                                    HomePhone = reader["HomePhone"] != DBNull.Value ? reader["HomePhone"].ToString() : "",
                                    LastName = reader["LastName"].ToString(),
                                    Salary = reader["Salary"] != DBNull.Value ? (decimal)reader["Salary"] : 0,
                                    Title = reader["Title"] != DBNull.Value ? reader["Title"].ToString() : "",
                                    TitleOfCourtesy = reader["TitleOfCourtesy"] != DBNull.Value ? reader["TitleOfCourtesy"].ToString() : "",
                                    Address = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : "",
                                    City = reader["City"] != DBNull.Value ? reader["City"].ToString() : "",
                                    Country = reader["Country"] != DBNull.Value ? reader["Country"].ToString() : "",
                                    PostalCode = reader["PostalCode"] != DBNull.Value ? reader["PostalCode"].ToString() : "",
                                    Region = reader["Region"] != DBNull.Value ? reader["Region"].ToString() : ""
                                });
                            }
                        }
                    }
                }
                return employees;
            }
            catch (Exception)
            {
                return new List<EmployeeModel>();
            }
        }

        public int GetOrderCount()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("spGetOrderCount", cn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cn.Open();

                        int customerCount = Convert.ToInt32(cmd.ExecuteScalar());

                        return customerCount;

                    }
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public List<OrderModel> GetOrderData()
        {
            List<OrderModel> orders = new List<OrderModel>();
            try
            {
                using (SqlConnection cn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("spListOrders", cn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                orders.Add(new OrderModel
                                {
                                    Freight = reader["Freight"] != DBNull.Value ? (decimal)reader["Freight"] : 0,
                                    OrderDate = reader["OrderDate"] != DBNull.Value ? (DateTime)reader["OrderDate"] : new DateTime(1900, 1, 1),
                                    RequiredDate = reader["RequiredDate"] != DBNull.Value ? (DateTime)reader["RequiredDate"] : new DateTime(1900, 1, 1),
                                    ShipAddress = reader["ShipAddress"] != DBNull.Value ? reader["ShipAddress"].ToString() : "",
                                    ShipCity = reader["ShipCity"] != DBNull.Value ? reader["ShipCity"].ToString() : "",
                                    ShipCountry = reader["ShipCountry"] != DBNull.Value ? reader["ShipCountry"].ToString() : "",
                                    ShipName = reader["ShipName"] != DBNull.Value ? reader["ShipName"].ToString() : "",
                                    ShippedDate = reader["ShippedDate"] != DBNull.Value ? (DateTime)reader["ShippedDate"] : new DateTime(1900, 1, 1),
                                    ShipPostalCode = reader["ShipPostalCode"] != DBNull.Value ? reader["ShipPostalCode"].ToString() : "",
                                    ShipRegion = reader["ShipRegion"] != DBNull.Value ? reader["ShipRegion"].ToString() : ""
                                });
                            }
                        }
                    }
                }
                return orders;
            }
            catch (Exception)
            {
                return new List<OrderModel>();
            }
        }
    }
}
