using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class EstrategiaA : Strategy
    {
        public override decimal Calculo(decimal total)
        {
            decimal porcentaje;
            porcentaje = (total * 15) / 100;
            total = total - porcentaje;
            return total;
        }
    }
}
