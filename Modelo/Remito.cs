using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("Remito")]
    public class Remito
    {
        public Remito()
        {
            LINEA_REMITO = new HashSet<LineaRemito>();
        }
        [Key]
        public int CODIGO_REMITO { get; set; }
        public DateTime FECHA_ENTREGA { get; set; }
        public Int32 CODIGO_ORDEN { get; set; }
        [ForeignKey("CODIGO_ORDEN")]
        public OrdenCompra ORDEN { get; set; }
        public virtual ICollection<LineaRemito> LINEA_REMITO { get; set; }
        public decimal TOTAL
        {
            get
            {
                decimal TOTAL = 0;
                foreach (var item in LINEA_REMITO.ToList())
                {
                    TOTAL += item.SUB_TOTAL;
                }
                return TOTAL;
            }
        }
    }
}
