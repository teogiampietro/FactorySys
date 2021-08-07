using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("Pedidos")]
    public class Pedido
    {
        public Pedido()
        {
            LINEA_PEDIDO = new HashSet<LineaPedido>();
        }
        [Key]
        public Int32 CODIGO_PEDIDO { get; set; }
        public Int32 CODIGO_CLIENTE { get; set; }
        [ForeignKey("CODIGO_CLIENTE")]
        public Cliente CLIENTE { get; set; }
        public ICollection<LineaPedido> LINEA_PEDIDO { get; set; }               
        public string DETALLE { get; set; }
        public DateTime FECHA_ENTREGA { get; set; }

        public decimal COSTO_TOTAL
        {
            get
            {
                decimal COSTO_TOTAL = 0;
                foreach (var item in LINEA_PEDIDO.ToList())
                {
                    COSTO_TOTAL += item.SUB_TOTAL_COSTO;
                }
                return COSTO_TOTAL;
            }
        }
        public decimal TOTAL
        {
            get
            {
                decimal TOTAL = 0;
                foreach (var item in LINEA_PEDIDO.ToList())
                {
                    TOTAL += item.SUB_TOTAL;
                }
                return TOTAL;
            }
        }
        public override string ToString()
        {
            return CODIGO_PEDIDO.ToString();
        }
    }
}
