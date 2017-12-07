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
                Console.WriteLine("C: Create \nR: Read \nU: Update \nD: Delete \nL: List all Orders \nM: mostrar de cada país cuál es el cliente con mayor compra y cual es el producto más vendido en ese país \nE: Exit");
                key = Console.ReadLine();
                switch (key.ToLower())
                {
                    case "c":
                        var newOrder = services.Create();
                        CreateOrder(newOrder, services);
                        break;
                    case "r":
                        try
                        {
                            var order = services.Read(CheckId());
                            Console.WriteLine($"ID: {order.OrderID} Fecha: {order.OrderDate.Value.ToShortDateString()} ShipAddress: {order.ShipAddress} City: {order.ShipCity} Country: {order.ShipCountry} Name: {order.ShipName}");

                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Algo fallo cuando tratabamos de mostrarte la orden");
                        }
                        break;
                    case "u":
                        Update();
                        break;
                    case "d":
                        services.Delete(CheckId());
                        break;
                    case "l":
                        ListAll(services.ListOrderDTO());
                        break;
                    case "m":
                        services.ListHighestCustomer();//arreglar
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

        private static void CreateOrder(OrderDTO order, Services service)
        {
            Console.WriteLine("DATOS DE PRUEBA:");//<----- BORRARRRRRRR
            Console.WriteLine("ALFKI - Davolio - Nancy - chai - tofu"); //<----- BORRARRRRRRR
            do
            {
                Console.Write("Ingrese el nombre del empleado: ");
                var nombreEmpleado = Console.ReadLine();

                Console.Write("Ingrese el apellido del empleado: ");
                var apellidoEmpleado = Console.ReadLine();

                var empoyeeID = service.ExistByName(nombreEmpleado, apellidoEmpleado);

                if (empoyeeID != -1)
                {
                    order.EmployeeID = empoyeeID;
                }
                else
                {
                    Console.WriteLine("No existe tal empleado, intente de nuevo");
                }

            } while (order.EmployeeID == null);

            bool exist;
            do
            {
                Console.WriteLine("Ingrese el ID del comprador: ");
                var compradorId = Console.ReadLine().ToUpper();
                exist = service.SearchCustomerByID(compradorId);
                order.CustomerID = compradorId;
            } while (!exist);

            order.OrderDate = DateTime.Today;
            Console.Write("Ingrese el nombre del envío: ");
            order.ShipName = Console.ReadLine();

            Console.Write("Ingrese la direccion de destino: ");
            order.ShipAddress = Console.ReadLine();

            Console.Write("Ingrese la ciudad de destino: ");
            order.ShipCity = Console.ReadLine();

            Console.Write("Ingrese la region de destino: ");
            order.ShipRegion = Console.ReadLine();

            Console.Write("Ingrese el codigo postal de destino: ");
            order.ShipPostalCode = Console.ReadLine();

            Console.Write("Ingrese el pais de destino: ");
            order.ShipCountry = Console.ReadLine();

            order.Order_Details = new List<OrderDetailsDTO>();
            string add;
            do
            {
                Console.WriteLine("Ingrese 'A' para agregar un producto o 'S' para Salir");
                add = Console.ReadLine().ToLower();

                switch (add.ToLower())
                {
                    case "a":
                        var orderDetail = new OrderDetailsDTO();
                        var productDTO = new ProductDTO();

                        do
                        {
                            Console.Write("Ingrese el nombre del producto: ");
                            var nombreProducto = Console.ReadLine();

                            var check = service.SearchProductByName(nombreProducto, productDTO);

                            if (check == -1)
                                Console.WriteLine("No existe el producto, intente de nuevo");
                            else
                                orderDetail.ProductID = productDTO.ProductID;
                            orderDetail.UnitPrice = productDTO.UnitPrice;

                        } while (orderDetail.ProductID == 0);

                        do
                        {
                            Console.Write("Ingrese la cantidad: ");
                            short quantity;
                            short.TryParse(Console.ReadLine(), out quantity);
                            orderDetail.Quantity = quantity;

                        } while (orderDetail.Quantity <= 0);

                        do
                        {
                            Console.Write("Ingrese el descuento: ");
                            float discount;
                            float.TryParse(Console.ReadLine(), out discount);
                            orderDetail.Discount = discount / 100;
                        } while (orderDetail.Discount < 0 || orderDetail.Discount > 30);
                        order.Order_Details.Add(orderDetail);
                        break;

                    case "s":
                        break;
                    default:
                        Console.WriteLine("Invalido, intente de nuevo");
                        break;
                }
            } while (add != "s");
            decimal? total = 0m;
            foreach (var item in order.Order_Details)
            {
                total += item.Quantity * item.UnitPrice;
            }


            order.OrderID = service.AddOrder(order);
            if (order.OrderID != -1)
                Console.WriteLine($"La Orden ID: {order.OrderID} con importe ${total} se ha creado exitosamente.");
            else
                Console.WriteLine("El id ha fallado");

            Console.ReadLine();
        }

        public static void ListAll(List<OrderListDTO> orders)
        {

            foreach (var item in orders)
            {
                Console.WriteLine($"{item.OrderID}\t{item.CustomerName}\t$ {item.Total}");
            }
        }

        public static void Update()
        {
            Console.Write("Ingrese la fecha en el siguiente formato dd-mm-yyyy: ");

            DateTime date;
            DateTime.TryParse(Console.ReadLine(), out date); //VALIDAR FORMATO DE LA FECHA!!!
                                                             // nuevaOrder.RequiredDate = date;
        }

        public static int CheckId()
        {
            int b;
            string id;
            do
            {
                Console.WriteLine("Ingrese un ID numerico");
                id = Console.ReadLine();
            } while (!int.TryParse(id, out b));
            return b;
        }
    }
}
