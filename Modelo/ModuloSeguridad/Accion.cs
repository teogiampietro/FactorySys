using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("Acciones")]
    public class Accion
    {
        [Key]
        public Int32 CODIGO_ACCION { get; set; }
        public string ACCION { get; set; }
        public ICollection<Formulario> FORMULARIOS { get; set; }
        
    }
}
