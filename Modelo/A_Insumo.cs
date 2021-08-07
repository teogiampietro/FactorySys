using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Modelo
{
    [Table("A_Insumos")]
    public class A_Insumo
    {
        [Key]
        public Int32 CODIGO { get; set; }
        public Int32 CODIGO_USUARIO { get; set; }
        public DateTime FECHA { get; set; }
        public string ACCION { get; set; }
        //INSUMO
        public string CODIGO_INSUMO { get; set; }
        public string NOMBRE_INSUMO { get; set; }
        public string DETALLE { get; set; }
        public Int32 CANTIDAD { get; set; }
        public Int32 STOCK_MIN { get; set; }
        public Int32 STOCK_MAX { get; set; }
        public decimal PRECIO { get; set; }

    }
}
