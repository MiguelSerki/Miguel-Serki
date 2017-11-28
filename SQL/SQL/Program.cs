using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3) ABM DE CATEGORIA
            Console.WriteLine("Ingrese un comando:");
            string key;
            do
            {
                Console.WriteLine("M, D, C. E para salir");
                key = Console.ReadLine();
                switch (key.ToLower())
                {
                    case "m":
                        M();
                        break;
                    case "d":
                        D();
                        break;
                    case "c":
                        C();
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

        public static void M()
        {
            /*'M' - -Al ingresar M pedir al usuario Id de categoria
             *Si no existe mostrar la categoria no existe(validar que sea un numero > 0)
             * Si existe mostrar categoria: { Nombre de categoria encontrada}
             *Luego pedir ingresar el[CategoryName] y[Description]
             * para actualizar */
            using (var context = new Model1())
            {
                var x = CheckId();
                try
                {
                    var categoria = context.Categories.Where(e => e.CategoryID == x).First();
                    Console.WriteLine($"Categoria: {categoria.CategoryName}");
                    Console.WriteLine("Ingrese un [CategoryName]");
                    categoria.CategoryName = Console.ReadLine();
                    Console.WriteLine("Ingrese una [Description]");
                    categoria.Description = Console.ReadLine();
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    Console.WriteLine("Algo horrible ha pasado y no encontramos esa categoria");
                }

            }
        }
        public static void D()
        {
            /*'D' - Al ingresar D pedir al usuario Id de categoria
             *Si no existe mostrar la categoria no existe(validar que sea un numero > 0)
             * Si existe verificar que no existe ningun producto asociado a la categoria, si existiera mostrar
             * No se puede eliminar la categoria existe un producto asociado*/
            using (var context = new Model1())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    var x = CheckId();
                    try
                    {
                        var categoria = context.Categories.Where(e => e.CategoryID == x).First();
                        Console.WriteLine($"Categoria: {categoria.CategoryName}");
                        if (categoria.Products.Any())
                        {
                            Console.WriteLine("No se puede eliminar la categoria, existe un producto asociado");
                        }
                        else
                        {
                            context.Categories.Remove(categoria);
                            Console.WriteLine(context.SaveChanges());
                            Console.WriteLine("Exito exitoso!");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Algo horrible ha pasado y no encontramos esa categoria");
                        transaction.Rollback();
                    }
                    transaction.Commit();
                }

            }
        }
        public static void C()
        {   /* 'C' - Pedir al usuario [CategoryName] y [Description] para crear una nueva categoria */
            using (var context = new Model1())
            {
                var category = new Categories();
                Console.WriteLine("Ingrese un [CategoryName]");
               category.CategoryName = Console.ReadLine();
                Console.WriteLine("ingrese una [Description]");
               category.Description = Console.ReadLine();
                context.Categories.Add(category);
                Console.WriteLine(context.SaveChanges());
                Console.WriteLine("Exito exitoso!");
            }
        }
        public static int CheckId()
        {
            string key;
            int id;
            do
            {
                Console.WriteLine("Ingrese un numero de ID");
                key = Console.ReadLine();
            } while (int.TryParse(key, out id) && id < 0);
            return id;
        }
        public static void Test()
        {
            using (var context = new Model1())
            {
                var empleados = context.Employees.Select(c => new
                {
                    Name = c.FirstName,
                    Surname = c.LastName,
                    Title = c.TitleOfCourtesy,
                    City = c.City,
                    Terry = c.Territories,
                });

                foreach (var item in empleados)
                {
                    Console.WriteLine($"{item.Title} {item.Surname} {item.Name}, {item.City}");
                    foreach (var item2 in item.Terry)
                    {
                        Console.WriteLine($"{item2.TerritoryDescription.Trim()} - {item2.Region.RegionDescription}");
                    }
                    Console.WriteLine("======================");
                }
            }
        }
    }
}

