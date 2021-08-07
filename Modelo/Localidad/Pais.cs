using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Modelo
{
    [Table("Paises")]
    public class Pais
    {
        [Key]
        public Int32 CODIGO_PAIS { get; set; }
        public string NOMBRE_PAIS { get; set; }
        public List<Provincia> LISTA_PROVINCIAS { get; set; }
    }
}
