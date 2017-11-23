using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataToTestLinq;

namespace Day8
{
    class Program
    {
        /*A partir del objeto DataContext del proyecto DataToTestLinq, 
         * realizar las siguientes consultas. 
        - Listar todas las personas mostrando nombre, país y edad. *
        - Listar las mujeres. 
        - Listar los hombres que pesen más de 70KG. 
        - Promedio de edad de las personas de la lista, sin incluir a sus hijos. 
        - Listar los hijos de cada persona. 
        - Promedio de edad por país. 
        - Promedio de peso por género. 
        - Persona con mayor peso. 
        - Persona con menor peso. 
        - Última persona de la lista. 
        - Listar personas que hablan más de un idioma mostrando el nombre y los idiomas que habla. 
        - Promedio de edad de los hijos de cada persona. 
        - Consultar si existe alguna persona llamada “Osvaldo”. 
        - Ordenar las personas por edad y listar las personas en 3ra y 4ta posición. 
*/
        static void Main(string[] args)
        {
            Console.WriteLine("Todas las personas");
            foreach (var item in TodasLasPersonas())
            {
                Console.WriteLine("Nombre: {0}, Pais: {1}, Edad: {2}", item.Name, item.Country, item.Age);
            }
            Console.WriteLine("Todas las mujeres");
            foreach (var item in Mujeres())
            {
                Console.WriteLine("Nombre: {0}", item.Name);
            }

            Console.WriteLine("Personas que pesan mas de 70");
            foreach (var item in Pesos())
            {
                Console.WriteLine("Nombre: {0}, Peso: {1}", item.Name, item.Weight);
            }

            Console.WriteLine("Promedio de edades de todas las personas");
            Promedio();
            Console.WriteLine("Promedio Por paises");

            foreach (var item in PromedioPaises())
            {
                Console.WriteLine("Pais: {0}, Promedio {1}", item);
            }


            Console.ReadLine();
        }

        public static IEnumerable<PersonModel> TodasLasPersonas()
        {
            return DataContext.People.Select(person => new PersonModel
            {
                Name = person.Name,
                Country = person.Country,
                Age = DateTime.Today.Year - person.DateOfBorn.Year
            }).Union(DataContext.People
                .Where(person => person.Children.Count() != 0)
                .SelectMany(person => person.Children)
                .Select(child => new PersonModel
                {
                    Name = child.Name,
                    Country = child.Country,
                    Age = DateTime.Today.Year - child.DateOfBorn.Year
                }));
        }
        public static IEnumerable<PersonName> Mujeres()
        {
            return DataContext.People
                .Where(person => person.Gender == Gender.Feminine)
                .Select(person => new PersonName
            {
                Name = person.Name,
            }).Union(DataContext.People
                .Where(person => person.Children.Count() != 0)
                .SelectMany(person => person.Children)
                .Where(child => child.Gender == Gender.Feminine)
                .Select(child => new PersonName
                {
                    Name = child.Name,
                }));
        }
        public static IEnumerable<PersonWeight> Pesos()
        {
            return DataContext.People
                .Where(person => person.Weight >70)
                .Select(person => new PersonWeight
            {
                Name = person.Name,
                Weight = person.Weight
            }).Union(DataContext.People
        .Where(person => person.Children.Count() != 0)
        .SelectMany(person => person.Children)
        .Where(child => child.Weight > 70)
        .Select(child => new PersonWeight
        {
            Name = child.Name,
            Weight = child.Weight
        }));
        }
        public static void Promedio()
        {
            var x = DataContext.People
                .Select(person => DateTime.Now.Year - person.DateOfBorn.Year)
                .Average();
            Console.WriteLine($"El total es {x}");
        }
        public static IEnumerable<object> PromedioPaises()
        {
            var x = DataContext.People
                .GroupBy(person => person.Country)
                .Select(y => new
                { Country = y.Key,
                  Avg = y.Select( z => DateTime.Now.Year - z.DateOfBorn.Year).Average()
                }
                    );
            return x;
        }

    }
        public class PersonModel
        {
            public string Name { get; set; }
            public string Country { get; set; }
            public int Age { get; set; }
        }

        public class PersonName
        {
            public string Name { get; set; }
        }
        
    public class PersonWeight
    {
        public string Name { get; set; }
        public decimal Weight { get; set; }
    }
    
}
