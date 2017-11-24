using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class Program
    {
        /*A partir del objeto DataContext del proyecto DataToTestLinq, 
         * realizar las siguientes consultas. 
        + Listar todas las personas mostrando nombre, país y edad. *
        + Listar las mujeres. 
        + Listar los hombres que pesen más de 70KG. 
        + Promedio de edad de las personas de la lista, sin incluir a sus hijos. 
        - Listar los hijos de cada persona. 
        + Promedio de edad por país. 
        + Promedio de peso por género. 
        + Persona con mayor peso. 
        + Persona con menor peso. 
        - Última persona de la lista.
        - Listar personas que hablan más de un idioma mostrando el nombre y los idiomas que habla. 
        - Promedio de edad de los hijos de cada persona. 
        - Consultar si existe alguna persona llamada “Osvaldo”. 
        - Ordenar las personas por edad y listar las personas en 3ra y 4ta posición. 
*/
        static void Main(string[] args)
        {

            Console.WriteLine("Todas las personas");
            foreach (var item in Servicios.TodasLasPersonas())
            {
                Console.WriteLine("Nombre: {0}, Pais: {1}, Edad: {2}", item.Name, item.Country, item.Age);
            }
            Salto();
            Console.WriteLine("Todas las mujeres");
            foreach (var item in Servicios.Mujeres())
            {
                Console.WriteLine("Nombre: {0}", item.Name);
            }
            Salto();
            Console.WriteLine("Personas que pesan mas de 70");
            foreach (var item in Servicios.Pesos())
            {
                Console.WriteLine("Nombre: {0}, Peso: {1}", item.Name, item.Weight);
            }
            Salto();
            Console.WriteLine("Promedio de edades de todas las personas");
            Console.WriteLine(Servicios.Promedio());
            Salto();
            Console.WriteLine("Promedio Por paises");
            foreach (var item in Servicios.PromedioPaises())
            {
                Console.WriteLine("Pais: {0}, Promedio {1}", item.Name, item.Avg);
            }
            Salto();
            Console.WriteLine("Promedio de pesos por genero");
            foreach (var item in Servicios.PesosPorGenero())
            {
                Console.WriteLine("Genero: {0}, Peso: {1}", item.Gender, item.Avg);
            }
            Salto();

            var x = Servicios.LaMasPesada();
            Console.WriteLine("La persona mas pesada es {0}, con {1} kilos", x.Name, x.Weight);
            Salto();
            var y = Servicios.LaMenosPesada();
            Console.WriteLine("La persona menos pesada es {0}, con {1} kilos", y.Name, y.Weight);
            Salto();
            Console.ReadLine();
        }

        public static void Salto()
        {
            Console.WriteLine("=============================");
        }
    }
}
