using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("Lineas_Productos")]
    public class LineaProducto
    {
        [Key]
        public Int32 CODIGO_LINEA_PRODUCTO { get; set; }
        public Int32 CODIGO_INSUMO { get; set; }
        [ForeignKey("CODIGO_INSUMO")]
        public Insumo INSUMO { get; set; }

        public Int32 CODIGO_PRODUCTO { get; set; }
        [ForeignKey("CODIGO_PRODUCTO")]
        public Producto PRODUCTO { get; set; }
        public int CANTIDAD { get; set; }
        public decimal COSTO { get; set; }
        public decimal SUB_TOTAL
        {
            get
            {
                decimal subtotal = this.COSTO * this.CANTIDAD;
                return subtotal;
            }
        }

    }
}
