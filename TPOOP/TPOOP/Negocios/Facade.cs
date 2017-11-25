using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPOOP.Datos;

namespace TPOOP.Negocios
{
    public class Facade
    {
        private Director<IEmpleados> Director;
        private EmpleadoBuilder<IEmpleados> Builder;

        public Facade()
        {
            this.Builder = new EmpleadoBuilder<IEmpleados>();
            this.Director = new Director<IEmpleados>(this.Builder);
        }

        public void OptionA()
        {

        }
        public void OptionB()
        {

        }
        public void OptionC()
        {

        }
        public void OptionL()
        {

        }
    }
}
