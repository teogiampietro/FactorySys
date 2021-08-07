using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    abstract public class Strategy
    {
        public abstract decimal Calculo(decimal total);
    }
}
