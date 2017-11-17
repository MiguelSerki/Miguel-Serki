using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacion__15_
{
    class Resta : Operacion
    {
        public override decimal Operar()
        {
            return this.valor1 - this.valor2;
        }
    }
}
