using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("Tipo")]
    public class Tipo
    {
        [Key]
        public Int32 CODIGO_TIPO { get; set; }
        public string NOMBRE { get; set; }
        public decimal GANANCIA { get; set; }
        public override string ToString()
        {
            return NOMBRE;
        }
    }
}
