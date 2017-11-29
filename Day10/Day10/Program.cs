using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocios;
namespace Day10
{
    class Program
    {

        static void Main(string[] args)
        {
            var facade = new Facade();
            Console.WriteLine("Ingrese un comando:");
            string key;
            do
            {
                Console.WriteLine("C: Create, R: Read, U: Update, D: Delete, E: Exit");
                key = Console.ReadLine();
                switch (key.ToLower())
                {
                    case "c":
                        var customer = facade.Create();

                        Console.WriteLine("Ingrese un nombre:");
                        customer.ContactName = Console.ReadLine();

                        Console.WriteLine("Ingrese una ciudad:");
                        customer.City = Console.ReadLine();

                        customer.CustomerID = facade.CheckId();

                        Console.WriteLine("Ingrese el nombre de la compania");
                        customer.CompanyName = Console.ReadLine();

                        facade.AddCustomer(customer);
                        break;
                    case "r":
                        facade.Read();
                        break;
                    case "u":
                        facade.Update();
                        break;
                    case "d":
                        facade.Delete();
                        break;
                    case "e":
                        Console.WriteLine("Vuelva prontos :)");
                        break;
                    default:
                        Console.WriteLine("Invalido, intente de nuevo");
                        break;
                }
            } while (key.ToLower() != "e");
            Console.ReadLine();
        }
    }
}
