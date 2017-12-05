using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new Services();
            Console.WriteLine("Ingrese un comando:");
            string key;
            do
            {
                Console.WriteLine("C: Create, R: Read, U: Update, D: Delete, L: List all Orders, E: Exit");
                key = Console.ReadLine();
                switch (key.ToLower())
                {
                    case "c":
                        services.Create();
                        break;
                    case "r":
                        try
                        {
                            var order = services.Read(CheckId());
                            Console.WriteLine($"ID: {order.OrderID} Fecha: {order.OrderDate.Value.ToShortDateString()} ShipAddress: {order.ShipAddress} City: {order.ShipCity} Country: {order.ShipCountry} Name: {order.ShipName}");

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                         break;
                    case "u":
                        break;
                    case "d":
                        services.Delete(CheckId());
                        break;
                    case "l":
                        services.ListAll();
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
        public static int CheckId()
        {
            int b;
            string id;
            //Arreglar
            do
            {
                Console.WriteLine("Ingrese un ID");
                id = Console.ReadLine();
            } while (!(int.TryParse(id, out b)) && b > 10000);
            return b;
        }
    }
}
