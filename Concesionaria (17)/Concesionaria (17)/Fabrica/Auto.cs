using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionaria__17_.Fabrica
{

    class Auto
    {
        public int Precio { get; set; }
        public enum Modelo
        {
            Modelo1,
            Modelo2,
            Modelo3,
            Modelo4
        };

        public void CheckModelo (Auto.Modelo n)
        {
          switch (n)
            {
                case Modelo.Modelo1:
                    Precio = 200000;
                    break;
                case Modelo.Modelo2:
                    Precio = 300000;
                    break;
                case Modelo.Modelo3:
                    Precio = 400000;
                    break;
                case Modelo.Modelo4:
                    Precio = 500000;
                    break;
                default:
                    Console.WriteLine("Modelo incorrecto");
                    break;
            }
        }
    }
}
