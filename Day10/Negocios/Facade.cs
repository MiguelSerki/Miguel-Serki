using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocios
{
    public class Facade
    {
        private CustomerRepository Repository = new CustomerRepository();

        public string CheckId()
        {
            string key;
       //     bool x;
            do
            {
                Console.WriteLine("Ingrese un codigo de ID (max 5 char)");
                key = Console.ReadLine().ToUpper();
               // x = key.Length > 0 && key.Length <= 5;
            } while (key.Length == 0 || key.Length > 5);
            return key;
        }

        public CustomerDTO Create()
        {
            return new CustomerDTO();
        }

        public void AddCustomer(CustomerDTO customer)
        {
           var Customer = Repository.CreateCustomer();
            Customer.City = customer.City;
            Customer.ContactName = customer.ContactName;
            Customer.CustomerID = customer.CustomerID;
            Repository.AddCustomer(Customer);
        }
    }

}
