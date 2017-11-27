﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPOOP.Datos
{
    public interface ISupervisor : IEmpleados
    {
        string Categoria { get; set; }
        decimal CalcularComision();
    }
}
