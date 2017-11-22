using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPOOP.Empleados
{
    interface IBuilderSupervisor
    {
        string Categoria { get; set; }
        decimal CalcularComision();
    }
}
