using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("Lineas_OrdenCompra")]
    public class LineaOrdenCompra
    {
        [Key]
        public Int32 CODIGO_LINEA_OC { get; set; }
        public Int32 CANTIDAD { get; set; }
        public decimal PRECIO { get; set; }
        public Int32 CODIGO_INSUMO { get; set; }
        [ForeignKey("CODIGO_INSUMO")]
        public Insumo INSUMO { get; set; }
        public Int32 CODIGO_ORDEN { get; set; }
        [ForeignKey("CODIGO_ORDEN")]
        public OrdenCompra ORDEN_COMPRA { get; set; }
        public Int32 CODIGO_ENTREGA { get; set; }
        [ForeignKey("CODIGO_ENTREGA")]
        public Entrega ENTREGA { get; set; }
        public decimal SUB_TOTAL
        {
            get
            {
                return this.PRECIO * this.CANTIDAD;   
            }
        }
        
    }
}
