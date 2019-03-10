using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class CustomerDAO
    {
        private SqlConnection dbConnection;
        public CustomerDAO()
        {
            string connString = ConfigurationManager.ConnectionStrings["DBConncectionString"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }
        public List<Customer> GetAll()
        {
            // gooi de db open voor gebruik
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tim_prog3_Customer", dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Customer> customers = new List<Customer>();
            while (reader.Read()) // .Read is een bool die leest of er nog te lezen valt, zo ja true, zo niet false
            {
                Customer customer = ReadCustomer(reader);
                customers.Add(customer);
            }
            // sluit de db 
            dbConnection.Close();
            return customers;
        }
        private Customer ReadCustomer(SqlDataReader reader)
        {
            return new Customer((int)reader["Id"], (string)reader["First Name"], (string)reader["Last Name"], (string)reader["EmailAddress"] );
        }
    }
}
