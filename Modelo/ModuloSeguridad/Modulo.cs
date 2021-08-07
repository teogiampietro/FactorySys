using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("Modulos")]
    public class Modulo
    {
        [Key]
        public Int32 CODIGO_MODULO { get; set; }
        public string NOMBRE { get; set; }
    }
}
