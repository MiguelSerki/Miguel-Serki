using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CustomerRepository
    {
        public Customers CreateCustomer()
        {
            return new Customers();
        }
        public void AddCustomer(Customers customer)
        {
            using (var context = new NorthwindEntities())
            {
                context.Customers.Add(customer);
                Console.WriteLine(context.SaveChanges());
            }
        }
        public void RemoveCustomer (Customers customer)
        {
            using (var context = new NorthwindEntities())
            {
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
        }
        public void UpdateCustomer (Customers customer)
        {
            using (var context = new NorthwindEntities())
            {
                

            }
        }
        public Customers getCustomer (string ID)
        {
            using (var context = new NorthwindEntities())
            {
                try
                {
                    return context.Customers.Where(c => c.CustomerID == ID).First();
                }
                catch (Exception)
                {
                    Console.WriteLine("No existe ese customer");
                    return null;
                }

            }
        }
    }
}
