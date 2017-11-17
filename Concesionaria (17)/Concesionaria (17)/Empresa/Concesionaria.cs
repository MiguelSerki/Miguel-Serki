
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionaria__17_.Empresa
{
    class Concesionaria
    {
   //     public Venta Ventas { get; set; }
        public List<Venta> lista { get; set; }

        public int Total()
        {
            int total = 0;
            foreach (Venta n in lista)
            {
                total += n.SubTotal();
            }
            return total;
        }
    }
}
