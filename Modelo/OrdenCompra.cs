using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("Ordenes Compra")]
    public class OrdenCompra
    {
        public OrdenCompra()
        {
            LINEAOC = new HashSet<LineaOrdenCompra>();
        }
        [Key]
        public Int32 CODIGO_ORDEN { get; set; }

        public virtual ICollection<Remito> REMITOS { get; set; }

        public Int32 CODIGO_PROVEEDOR { get; set; }
        [ForeignKey("CODIGO_PROVEEDOR")]
        public Proveedor PROVEEDOR { get; set; }
            
        public virtual ICollection<LineaOrdenCompra> LINEAOC { get; set; }
        
        public bool VERIFICADO { get; set; }
        public DateTime FECHA_EMISION { get; set; }
        public decimal TOTAL
        {
            get
            {
                decimal total = 0;
                 foreach (var item in LINEAOC.ToList())
                {
                    total += item.SUB_TOTAL;
                }
                return total;
            }
        }
        public string ESTADO { get; set; }
    }
}
