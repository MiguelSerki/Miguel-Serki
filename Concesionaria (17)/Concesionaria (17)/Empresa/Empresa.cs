using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionaria__17_.Empresa
{
    class Empresa
    {
        public List<Concesionaria> Lista  { get; set; }

        public Empresa()
        {

        }

        public void TotalVentas()
        {

            int TotalAbsoluto = 0;
            foreach (Concesionaria n in Lista)
            {
                TotalAbsoluto += n.Total();
            }
        }
    }
}
