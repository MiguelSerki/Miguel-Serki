using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Interface.Ejercicio27
{
    /*
     * Desarrollar un método genérico que reciba dos colecciones del tipo IEnumerable<T> 
     * donde T debe ser una clase e internamente haga la intersección de ambas colecciones 
     * y retorne el primer ítem o el valor por defecto. 
     */
    public class E27 <U>
    {
        public U Interseccion<T>(T x, T y) where T : IEnumerable<U>
        {
            return x.Intersect(y).FirstOrDefault();
        }
    }
}
