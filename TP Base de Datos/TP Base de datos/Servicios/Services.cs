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
        private Repository<Order> Repository;

        public Services()
        {
            this.Repository = new Repository<Order>();
        }

        public OrderDTO Create()
        {
            return new OrderDTO();
        }

        public void AddOrder(OrderDTO order)
        {
        }

        public void Delete(int id)
        {
            try
            {
                var order = this.Repository.GetById(id);

                if (order.Customer.Country == "France" || order.Customer.Country == "Mexico")
                {
                    Console.WriteLine("No se puede eliminar la orden porque su cliente es de Francia o Mexico");
                }
                else
                {
                    var DetailsRepo = new Repository<Order_Detail>();
                    var orders = DetailsRepo.Set().Where(d => d.OrderID == order.OrderID);
                    foreach (var detail in orders)
                    {
                        DetailsRepo.Remove(detail);
                    }
                    DetailsRepo.SaveChanges();
                    this.Repository.Remove(order);
                    this.Repository.SaveChanges();
                    Console.WriteLine("Removido con exito");
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void ListAll()
        {
            var list = this.Repository.Set();
            foreach (var order in list)
            {
                Console.WriteLine($"ID: {order.OrderID} Nombre de cliente: {order.Customer.ContactName} Importe: {order.Freight}"); //en vez de freight, poner suma de los productos de cada orden
            }
        }

        public OrderDTO Read(int id)
        {
            try
            {
                var order = Repository.GetById(id);
                var orderDTO = new OrderDTO();
                orderDTO.OrderID = order.OrderID;
                orderDTO.CustomerID = order.CustomerID;
                orderDTO.OrderDate = order.OrderDate;
                orderDTO.ShipAddress = order.ShipAddress;
                orderDTO.ShipCity = order.ShipCity;
                orderDTO.ShipCountry = order.ShipCountry;
                orderDTO.ShipName = order.ShipName;
                return orderDTO;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
