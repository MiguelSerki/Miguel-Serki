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

        public int AddOrder(OrderDTO order)
        {
            try
            {
                Order newOrder = new Order();
                MapOrders(order, newOrder);
                Repository.Persist(newOrder);
                Repository.SaveChanges();
                return newOrder.OrderID;
            }
            catch (Exception)
            {
                Console.WriteLine("Algo horroroso ha pasado!");
                return -1;
            }

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

        public List<OrderListDTO> ListOrderDTO()
        {
            var list = new List<OrderListDTO>();
            var data = this.Repository.Set().ToList();

            foreach (var order in data)
            {
                list.Add(new OrderListDTO()
                {
                    OrderID = order.OrderID,
                    CustomerName = order.Customer.ContactName,
                    Total = this.TotalSum(order)
                });
            }
            return list;
        }

        public decimal TotalSum(Order order)
        {
            var total = 0m;
            foreach (var item in order.Order_Details)
            {
                total += item.UnitPrice * item.Quantity;
            }

            return total;
        }

        public List<BestCustomerProductByCountry> ListHighestCustomer()
        {
            var allCustomers = new Repository<Customer>().Set();

            var customerList = allCustomers.GroupBy(x => x.Country)
                .Select(x => new BestCustomerDTO
                {
                    CountryName = x.Key,
                    CustomerName = x
                        .OrderByDescending(c => c.Orders
                        .Sum(g => g.Order_Details
                        .Sum(d => d.Quantity * d.Product.UnitPrice)))
                        .Select(h => h.ContactName)
                        .FirstOrDefault(),
                    Total = x.Select(v => v.Orders
                        .Where(c => c.CustomerID == x
                        .OrderByDescending(w => w.Orders
                        .Sum(g => g.Order_Details
                        .Sum(d => d.Quantity * d.Product.UnitPrice)))
                        .Select(h => h.CustomerID)
                        .FirstOrDefault())
                        .Sum(g => g.Order_Details
                        .Sum(d => d.Quantity * d.Product.UnitPrice)))
                        .Sum()
                })
                .ToList();

            var productList = allCustomers.GroupBy(x => x.Country)
                .Select(x => new BestProductDTO
                {
                    CountryName = x.Key,
                    ProductName = x 
                    .SelectMany(c => c.Orders)
                    .SelectMany(v => v.Order_Details)
                    .GroupBy(b => b.ProductID)
                    .OrderByDescending(t => t.Count())
                    .FirstOrDefault()
                    .Select(b => b.Product.ProductName)
                    .FirstOrDefault()
                })
                .ToList();

            var data = new List<BestCustomerProductByCountry>();

            foreach (var product in productList)
                foreach (var customer in customerList)
                    if (product.CountryName == customer.CountryName)
                    {
                        var item = new BestCustomerProductByCountry()
                        {
                            CountryName = product.CountryName,
                            CustomerName = customer.CustomerName,
                            ProductName = product.ProductName,
                            Total = (decimal)customer.Total
                        };

                        data.Add(item);
                    }
            return data;
        }

        public OrderDTO Read(int id)
        {
            try
            {
                var order = Repository.GetById(id);
                var orderDTO = new OrderDTO();
                ReverseMap(orderDTO, order);
                return orderDTO;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int ExistByName(string nombre, string apellido)
        {

            try
            {
             return new Repository<Employee>().Set().Where(e => e.FirstName == nombre && e.LastName == apellido).First().EmployeeID;
            }
            catch (Exception)
            {
                return -1;
            }
           
        }

        public int SearchProductByName(string nombre, ProductDTO product)
        {
            try
            {
                var repoProduct = new Repository<Product>().Set().Where(e => e.ProductName == nombre).First();
                product.ProductID = repoProduct.ProductID;
                product.ProductName = repoProduct.ProductName;
                product.UnitPrice = repoProduct.UnitPrice;
                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public bool SearchCustomerByID(string id)
        {
            try
            {
              return new Repository<Customer>().Set().Select(c => c.CustomerID == id).FirstOrDefault();

            }
            catch (Exception)
            {
                return false;
            }
        }

        public void MapOrders(OrderDTO dto, Order order)
        {
<<<<<<< HEAD
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
=======
            order.CustomerID = dto.CustomerID;
            order.EmployeeID = dto.EmployeeID;
            order.Freight = dto.Freight;
            order.OrderDate = dto.OrderDate;
            order.RequiredDate = dto.RequiredDate;
            order.ShipAddress = dto.ShipAddress;
            order.ShipCity = dto.ShipCity;
            order.ShipCountry = dto.ShipCountry;
            order.ShipName = dto.ShipName;
            order.ShippedDate = dto.ShippedDate;
            order.ShipPostalCode = dto.ShipPostalCode;
            order.ShipRegion = dto.ShipRegion;
            order.ShipVia = dto.ShipVia;

            if(dto.Order_Details != null)
            {
                foreach (var item in dto.Order_Details)
                {
                    order.Order_Details.Add(new Order_Detail
                    {
                        OrderID = order.OrderID,
                        ProductID = item.ProductID,
                        Order = order,
                        Quantity = item.Quantity,
                        UnitPrice = (decimal)item.UnitPrice,
                        Discount = item.Discount,
                    });
                }
>>>>>>> 15876affaf1662ac1f545ccf553a4517cb72a383
            }
           
        }

        public void ReverseMap(OrderDTO dto, Order order)
        {
            dto.CustomerID = order.CustomerID;
            dto.EmployeeID = order.EmployeeID;
            dto.Freight = order.Freight;
            dto.OrderDate = (DateTime)order.OrderDate;
            dto.OrderID = order.OrderID;
            dto.RequiredDate = order.RequiredDate;
            dto.ShipAddress = order.ShipAddress;
            dto.ShipCity = order.ShipCity;
            dto.ShipCountry = order.ShipCountry;
            dto.ShipName = order.ShipName;
            dto.ShippedDate = order.ShippedDate;
            dto.ShipPostalCode = order.ShipPostalCode;
            dto.ShipRegion = order.ShipRegion;
            dto.ShipVia = order.ShipVia;
            dto.Order_Details = new List<OrderDetailsDTO>();
            foreach (var item in order.Order_Details)
            {
                dto.Order_Details.Add(new OrderDetailsDTO
                {
                    OrderID = item.OrderID,
                    ProductID = item.ProductID,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice,
                    Discount = item.Discount,
                });
            }
        }

        public int DoesOrderExist(int id)
        {
            try
            {
                return Repository.GetById(id).OrderID;
            }
            catch (Exception)
            {
                Console.WriteLine("No existe esa orden");
                return -1;
            }
        }

        public int UpdateOrder(OrderDTO order)
        {
            try
            {
                var updateOrder = this.Repository.GetById(order.OrderID);

                this.MapOrders(order, updateOrder);

                this.Repository.Update(updateOrder);

                this.Repository.SaveChanges();

                return 0;
            }
            catch (Exception)
            {
                return -1;
            }

        }
    }
}
