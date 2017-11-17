using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacion__15_
{
    public abstract class Operacion {
        public decimal valor1 { get; set; }
        public decimal valor2 { get; set; }


        public abstract decimal Operar();

    }
}
