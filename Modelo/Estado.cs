using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("Estados")]
    public class Estado
    {
        [Key]
        public Int32 CODIGO_ESTADO { get; set; }
        public string NOMBRE { get; set; }
        public override string ToString()
        {
            return NOMBRE;
        }
    }
}
