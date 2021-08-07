using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("Linea_OrdenFabricación")]
    public class LineaOrdenFabricación
    {
        [Key]
        public Int32 CODIGO_LINEA_OF { get; set; }
        public Int32 CODIGO_TAREA { get; set; }
        [ForeignKey("CODIGO_TAREA")]
        public Tarea TAREA { get; set; }
        public string DETALLE { get; set; }

    }
}
