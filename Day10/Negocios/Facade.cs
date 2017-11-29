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
        private Repository<Customers> Repository = new Repository<Customers>();
        private CustomerRepository Rep = new CustomerRepository();

        public string CheckId()
        {
            string key;
            do
            {
                Console.WriteLine("Ingrese un codigo de ID (max 5 char)");
                key = Console.ReadLine().ToUpper();
            } while (key.Length == 0 || key.Length > 5);
            return key;
        }

        public CustomerDTO Create()
        {
            return new CustomerDTO();
        }

        public void AddCustomer(CustomerDTO customer)
        {
           var Customer = Rep.CreateCustomer();
            Customer.City = customer.City;
            Customer.ContactName = customer.ContactName;
            Customer.CustomerID = customer.CustomerID;
            Customer.CompanyName = customer.CompanyName;
            Repository.Persist(Customer);
        }

        public void Read()
        {
            var key = CheckId();
            try
            {
                var customer = Repository.GetCustomer(key);
                Console.WriteLine($"Nombre: {customer.ContactTitle} {customer.ContactName}, " +
                    $"Ciudad: {customer.City}," +
                    $" Direccion: {customer.City}");
            }
            catch (Exception)
            {
                Console.WriteLine("Ingrese un ID valido.");
            }
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            var key = CheckId();
            try
            {
                var customer = Repository.GetCustomer(key);
                Console.WriteLine("Ingrese un nuevo nombre");
                customer.ContactName = Console.ReadLine();
                customer.CustomerID = CheckId();
                Repository.UpdateCustomer();
            }
            catch (Exception)
            {
                Console.WriteLine("Ingrese un ID valido.");
            }
        }
    }

}
