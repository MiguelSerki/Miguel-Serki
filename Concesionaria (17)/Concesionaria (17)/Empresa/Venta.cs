using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concesionaria__17_.Fabrica;

namespace Concesionaria__17_.Empresa
{
    class Venta
    {
        public int Cantidad { get; set; }
        public Auto auto { get; set; }


        public int SubTotal()
        {
            return Cantidad * auto.Precio;
        }
    }


}
