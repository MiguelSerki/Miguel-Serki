using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
   public class OrderListDTO
    {
        public int OrderID { get; set; }
        public decimal Total { get; set; }
        public string CustomerName { get; set; }
    }
}
