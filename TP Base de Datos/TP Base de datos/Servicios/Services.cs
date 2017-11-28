using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Servicios
{
    public class Services
    {

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

        public OrderDTO Create()
        {
            return new OrderDTO();
        }

        public void AddOrder(OrderDTO order)
        {

            using (var context = new Context()){
                var Order = new Order();
            }
        }
    }
}
