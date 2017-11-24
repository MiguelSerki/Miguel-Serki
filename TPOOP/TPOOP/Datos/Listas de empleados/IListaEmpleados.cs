using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPOOP.Datos
{
    public interface IListaEmpleados
    {
        IEmpleados MejoresPago();
        IEmpleados GetEmpleado(string Dni);
    }
}
