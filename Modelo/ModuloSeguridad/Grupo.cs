using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("Grupos")]
    public class Grupo
    {
        /*public Grupo()
       {
            USUARIOS = new HashSet<Usuario>();
        }*/
        [Key]
        public Int32 CODIGO_GRUPO { get; set; }
        public string NOMBRE { get; set; }
        public virtual ICollection<Usuario> USUARIOS { get; set; }
        public virtual ICollection<Permiso> PERMISOS { get; set; }
        
        public override string ToString()
        {
            return NOMBRE;
        }
    }
}
