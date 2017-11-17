using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.Animales;

namespace Veterinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> lista = new List<Animal>
            {
                new Perro (){
                    Nombre = "Beethoven"
                },
                new Gato()
                {
                    Nombre = "Mauri"
                },
                new Pajaro()
                {
                    Nombre = "Piolin"
                }

            };

            foreach (Animal n in lista)
            {
                n.Saludo();
            }
            Console.ReadLine();
        }
    }
}
