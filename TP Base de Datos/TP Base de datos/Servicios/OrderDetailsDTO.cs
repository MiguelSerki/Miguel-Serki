using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class OrderDetailsDTO
    {

        public int OrderID { get; set; }

        public int ProductID { get; set; }

<<<<<<< HEAD
        public decimal UnitPrice { get; set; }
=======
        public decimal? UnitPrice { get; set; }
>>>>>>> 15876affaf1662ac1f545ccf553a4517cb72a383

        public short Quantity { get; set; }

        public float Discount { get; set; }

<<<<<<< HEAD
        public virtual OrderDTO Order { get; set; }
=======
>>>>>>> 15876affaf1662ac1f545ccf553a4517cb72a383
    }
}
