using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("Lineas_Pedidos")]
    public class LineaPedido
    {
        [Key]
        public Int32 CODIGO_LINEA_PEDIDO { get; set; }
        public Int32 CODIGO_PRODUCTO { get; set; }
        [ForeignKey("CODIGO_PRODUCTO")]
        public Producto PRODUCTO { get; set; }
        public int CANTIDAD { get; set; }
        public decimal COSTO { get; set; }
        public decimal PRECIO { get; set; }
        public decimal SUB_TOTAL_COSTO
        {
            get
            {               
                return COSTO * CANTIDAD;
            }
        }
        public decimal SUB_TOTAL
        {
            get
            {
                return PRECIO * CANTIDAD;
            }
        }
        
    }
}
