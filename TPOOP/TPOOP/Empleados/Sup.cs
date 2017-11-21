using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPOOP.Empleados
{
    public abstract class Sup : Personal
    {
        public string Categoria { get; set; }

        public int Comision()
        {
            switch (this.Categoria.ToLower()){

                case "a":
                    return 10;
                case "b":
                    return 5;
                case "c":
                    return 2;
                default:
                    Console.WriteLine("Hubo un error al ingresar la categoria de supervisor");
                    return 0;
            }

        }
    }
}
