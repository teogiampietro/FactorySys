using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("Insumos")]
    public class Insumo
    {
        [Key]
        public Int32 CODIGO { get; set; }
        public string CODIGO_INSUMO { get; set; }
        public string NOMBRE_INSUMO { get; set; }    
        public string DETALLE { get; set; }
        public Int32 CANTIDAD { get; set; }
        public Int32 STOCK_MIN { get; set; }
        public Int32 STOCK_MAX { get; set; }
        public decimal PRECIO { get; set; }
        public override string ToString()
        {
            return NOMBRE_INSUMO;
        }     
    }
}
