using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /*
        * Crea una clase llamada Cuenta que tendra los siguientes atributos: titular y cantidad (puede tener decimales).
        * El titular sera obligatorio y la cantidad es opcional.
        * crea dos constructores que cumpla lo anterior.
        * Crea sus propiedades.
        * 
        * Tendra dos metodos especiales:
        * 
        * Ingresar (decimal cantidad): se ingresa una cantidad a la cuenta, si la cantidad es negativa, no se hara nada.
        * Retirar (decimal cantidad): se retira una cantidad a la cuenta, si restando la cantidad actual a la que nos
        * pasan es negativa, la cantidad pasa a ser 0.
        */
    class Cuenta
    {
        private float Cantidad { get; set; }
        private string Titular { get; set; }
        public Cuenta(string titular)
        {
            Titular = titular;
        }
        public Cuenta(string titular, float cantidad)
            :this(titular)
        {
            Cantidad = cantidad;
        }

        public void Ingresar ()
        {
            Console.WriteLine("usted va a ingresar dinero");
            float valor = AskValue();
            if (valor > 0)
            {
                Cantidad += valor;
            }
            Saldo();
        }
        public void Retirar ()
        {
            Console.WriteLine("Usted va a retirar dinero");
            Cantidad -= AskValue();
            if (Cantidad < 0)
            {
                Cantidad = 0;
            }
            Saldo();
        }

        public void Saldo()
        {
            Console.WriteLine("Su saldo es {0}", Cantidad);
        }
        private float AskValue()
        {
            string ingresar;
            float value = 0;
            do
            {
                Console.WriteLine("Ingrese un valor");
                ingresar = Console.ReadLine();
            } while (!(float.TryParse(ingresar, out value)));
            return value;
        }
    }
}
