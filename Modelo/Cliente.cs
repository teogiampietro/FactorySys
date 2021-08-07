using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public Int32 CODIGO_CLIENTE { get; set; }
        public string NOMBRE { get; set; }
        public string DIRECCION { get; set; }
        public Int32 CODIGO_LOCALIDAD { get; set; }
        [ForeignKey("CODIGO_LOCALIDAD")]
        public Localidad LOCALIDAD { get; set; }
        public string DNI { get; set; }
        public string TELEFONO { get; set; }
        public string CELULAR { get; set; }
        public string EMAIL { get; set; }    
        public string CATEGORIA { get; set; }
        public string OBSERVACIONES { get; set; }
        public override string ToString()
        {
            return NOMBRE;
        }
    }
}
