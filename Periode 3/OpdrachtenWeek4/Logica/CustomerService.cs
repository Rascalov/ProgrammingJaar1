using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logica
{
    public class CustomerService
    {
        private CustomerDAO customerDAO = new CustomerDAO();
        public List<Customer> GetAll()
        {
            return customerDAO.GetAll();
        }
        public Customer GetById(int id)
        {
            Console.WriteLine($"Getting Customer with id {id}...");
            return customerDAO.GetByID(id);
        }
    }
}
