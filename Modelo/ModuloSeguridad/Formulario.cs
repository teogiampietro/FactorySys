using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("Formularios")]
    public class Formulario
    {
        [Key]
        public Int32 CODIGO_FORMULARIO { get; set; }
        public Int32 CODIGO_MODULO { get; set; }
        [ForeignKey("CODIGO_MODULO")]
        public Modulo MODULO { get; set; }
        public string NOMBRE { get; set; }
        public ICollection<Accion> ACCIONES { get; set; }
    }
}
