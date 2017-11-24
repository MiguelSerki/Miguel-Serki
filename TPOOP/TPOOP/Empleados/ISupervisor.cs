using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPOOP.Empleados
{
    public interface ISupervisor
    {
        string Categoria { get; set; }
        decimal CalcularComision();
    }
}
