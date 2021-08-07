using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class EstrategiaC : Strategy
    {
        public override decimal Calculo(decimal total)
        {
            return total;
        }
    }
}
