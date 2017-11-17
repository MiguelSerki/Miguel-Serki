using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public abstract class Animal
    {
        public string Nombre { get; set; }

        public abstract void Saludo();

    }
}
