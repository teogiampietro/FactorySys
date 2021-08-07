using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Modelo
{
    [Table("Usuarios")]
    public class Usuario
    {
        public Usuario()
        {
            GRUPO = new HashSet<Grupo>();   
        }
        [Key]
        public Int32 CODIGO_USUARIO { get; set; }
        public string NOMBRE { get; set; }
        public string USUARIO { get; set; }
        public string CONTRASEÑA { get; set; }
        public string EMAIL { get; set; }
        public ICollection<Modelo.Grupo> GRUPO { get; set; }        
        public bool PRIMERA { get; set; }
        public override string ToString()
        {
            return NOMBRE;
        }
    }
}
