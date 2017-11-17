using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Animales
{
    class Gato : Animal
    {
        public override void Saludo()
        {
            Console.WriteLine("{0} dice Privatizacion!", this.Nombre);
        }
    }
}
