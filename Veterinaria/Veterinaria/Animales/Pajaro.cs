using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Animales
{
    class Pajaro : Animal
    {
        public override void Saludo()
        {
            Console.WriteLine("{0} dice Pio Pio!", this.Nombre);
        }
    }
}
