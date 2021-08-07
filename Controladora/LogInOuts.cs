using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class LogInOuts
    {
        public static LogInOuts instancia;
        public static LogInOuts OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new LogInOuts();
            }
            return instancia;
        }
        Modelo.Fabrica oFabrica;
        public LogInOuts()
        {
            oFabrica = Modelo.Fabrica.OBTENER_INSTANCIA();
        }
        public void AGREGAR_LOGINOUT(Modelo.LogInOut oLog)
        {
            oFabrica.LOGINOUT.Add(oLog);
            oFabrica.SaveChanges();
        }
        public System.Collections.IEnumerable LISTAR_LOGINOUT()
        {
            var logs = from log in oFabrica.LOGINOUT.ToList()
                       select new
                       {
                           CODIGO = log.CODIGO,
                           USUARIO = log.USUARIO,
                           FECHA = log.FECHA,
                           ACCION = log.ACCION
                          };
            return logs.ToList();
        }
    }
}
