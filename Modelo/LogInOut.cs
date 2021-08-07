using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("LogInOut")]
    public class LogInOut
    {
        [Key]
        public Int32 CODIGO { get; set; }
        public Int32 CODIGO_USUARIO { get; set; }
        [ForeignKey("CODIGO_USUARIO")]
        public Usuario USUARIO { get; set; }

        public DateTime FECHA { get; set; }
        public string ACCION { get; set; }
    }
}
