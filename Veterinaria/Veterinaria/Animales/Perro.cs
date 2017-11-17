using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Animales
{
    class Perro : Animal
    {
        public override void Saludo()
        {
            Console.WriteLine("{0} dice Guau Guau!", this.Nombre);
        }
    }
}
