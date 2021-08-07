using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("OrdenFabricacion")]
    public class OrdenFabricacion
    {
        public OrdenFabricacion()
        {
            LINEA_OF = new HashSet<LineaOrdenFabricación>();
        }
        [Key]
        public Int32 CODIGO_OF { get; set; }
        public virtual ICollection<LineaOrdenFabricación> LINEA_OF { get; set; }
        public string DESCRIPCION { get; set; }

        public Int32 CODIGO_ESTADO { get; set; }
        [ForeignKey("CODIGO_ESTADO")]
        public Estado ESTADO { get; set; }

        public Int32 CODIGO_PEDIDO { get; set; }
        [ForeignKey("CODIGO_PEDIDO")]
        public Pedido PEDIDO { get; set; }

        public Int32 CODIGO_USUARIO { get; set; }
        [ForeignKey("CODIGO_USUARIO")]
        public Usuario USUARIO { get; set; }


    }
}
