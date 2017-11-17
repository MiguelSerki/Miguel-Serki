using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
 /*
Generar los metodos 
EsFuerte() que devuelve un bool si la clave interna contiene al menos 1 numero y una mayuscula
Clave(bool generar) que devuelve la clave y toma un bool que indica si debe debe regenerar la clave con la longitud interna y luego devuelve la clave.

Crear una app de consola que permita el ingreso al usuario de una longitud para su generador de password y que el sistema le permita las siguientes operaciones
 - Si ingresa 'e' indicar si su clave es fuerte o 'No tiene clave' si aun no la genero

 - Si ingresa 'c' se debe preguntar si se desea generar nuevamente con 's' o 'n' ( Pedir dato hasta que sea correcto) y luego mostrar la clave

 - Si ingresa 'f' - Finalizar el sistema

 Pedir operaciones hasta que el usuario ingrese f.
 */
    class Password
    {
        private int Longitud { get; set; }
        private string Clave { get; set; }

        public Password(int longitud = 8)
        {
            Longitud = CheckLong(longitud);
        }


        public void ClaveBool (bool generar)
        {

            foreach (char n in Clave)
            {
               // if(Clave.IndexOf(n) is int)
            }
        }
        public bool EsFuerte()
        {
            if (Clave.Length == 0)
            {
                Console.WriteLine("No tienes clave todavia");
            }

            return false;
        }
        public static int CheckLong(int longitud)
        {
            if (longitud <= 0)
            {
                return 8;
            }
            else
            {
                return longitud;
            }
              
        }
    }
}
