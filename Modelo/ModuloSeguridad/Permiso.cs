using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("Permisos")]
    public class Permiso
    {
        [Key]
        public Int32 CODIGO_PERMISO { get; set; }

        public string DESCRIPCION { get; set; }
        public Int32 CODIGO_ACCION { get; set; }
        [ForeignKey("CODIGO_ACCION")]
        public Accion ACCION { get; set; }

        public Int32 CODIGO_FORMULARIO { get; set; }
        [ForeignKey("CODIGO_FORMULARIO")]
        public Formulario FORMULARIO { get; set; }

        public Int32 CODIGO_GRUPO { get; set; }
        [ForeignKey("CODIGO_GRUPO")]
        public Grupo GRUPO { get; set; }

        


    }
}
