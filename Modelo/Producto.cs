using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("Productos")]
    public class Producto
    {
        public Producto()
        {
            LINEA_PRODUCTO = new HashSet<LineaProducto>();
        }
        [Key]
        public Int32 CODIGO_PRODUCTO { get; set; }
        public string CODIGO { get; set; }
        public string DESCRIPCION { get; set; }
        public string DETALLE { get; set; }
        public Int32 CANTIDAD { get; set; }
        public ICollection<LineaProducto> LINEA_PRODUCTO { get; set; }
        public decimal COSTO_PRODUCTO { get; set; }
        public Int32 CODIGO_TIPO { get; set; }
        [ForeignKey("CODIGO_TIPO")]
        public Tipo TIPO { get; set; }      
        public override string ToString()
        {
            return DESCRIPCION;
        }

    }
}
