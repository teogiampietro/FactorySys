using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Modelo
{
    [Table("Localidades")]
    public class Localidad
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public Int32 CODIGO_LOCALIDAD { get; set; }
        public Int32 CODIGO_PROVINCIA { get; set; }
        [ForeignKey("CODIGO_PROVINCIA")]
        public Provincia PROVINCIA { get; set; }
        public string NOMBRE_LOCALIDAD { get; set; }
        public List<Proveedor> LISTA_PROVEEDORES { get; set; }
        public override string ToString()
        {
            return NOMBRE_LOCALIDAD;
        }

    }
}
