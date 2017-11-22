using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Interface.Ejercicio30
{
    public class Gato : IE30
    {
        public string Nombre { get; set; }

        public void Saludar()
        {
            Console.WriteLine("{0} dice miau miau!", this.Nombre);
        }
    }

    public class Perro : IE30
    {
        public string Nombre { get; set; }

        public void Saludar()
        {
            Console.WriteLine("{0} dice guau guau", this.Nombre);
        }
    }

    public class Pajaro : IE30
    {
        public string Nombre { get; set; }

        public void Saludar()
        {
            Console.WriteLine("{0} dice pio pio", this.Nombre);
        }
    }

}
