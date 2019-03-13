using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Logica;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            CustomerService customerService = new CustomerService();
            foreach (Customer c in customerService.GetAll())
            {
                Console.WriteLine(c);
            }
            Customer cust = customerService.GetById(2);
            Console.WriteLine($"{cust.FullName} ({cust.EmailAddress})");
        }
    }
}
