using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Modelo
{
    [Table("Provincias")]
    public class Provincia
    {
        [Key]
        public Int32 CODIGO_PROVINCIA { get; set; }
        public Int32 CODIGO_PAIS { get; set; }
        [ForeignKey("CODIGO_PAIS")]
        public Pais PAIS { get; set; }
        public string NOMBRE_PROVINCIA { get; set; }
        public List<Localidad> LISTA_LOCALIDADES { get; set; }
    }
}
