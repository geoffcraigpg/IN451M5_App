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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<CustomerModel>();
            }
        }
    }
}
