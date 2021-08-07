using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
     
    public class A_Insumos
    {
        public static A_Insumos instancia;
        public static A_Insumos OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new A_Insumos();
            }
            return instancia;
        }
        Modelo.Auditoria oAuditoria;
        public A_Insumos()
        {
            oAuditoria = Modelo.Auditoria.OBTENER_INSTANCIA();
        }
        public void AGREGAR_A_INSUMOS(Modelo.A_Insumo oA_Insumo)
        {
            oAuditoria.A_INSUMOS.Add(oA_Insumo);
            oAuditoria.SaveChanges();
        }
        public System.Collections.IEnumerable LISTAR_A_INSUMOS()//toma como parametros default, entonces me trae todas las busquedas.
        {
            var insumos = from insumo in oAuditoria.A_INSUMOS.ToList()
                           select new
                           {
                               CODIGO = insumo.CODIGO,
                               FECHA = insumo.FECHA,
                               USUARIO = insumo.CODIGO_USUARIO,
                               ACCION = insumo.ACCION,
                               CODIGO_INSUMO = insumo.CODIGO_INSUMO,
                               NOMBRE_INSUMO = insumo.NOMBRE_INSUMO,
                               DETALLE = insumo.DETALLE,
                               STOCK_MIN = insumo.STOCK_MIN,
                               STOCK_MAX = insumo.STOCK_MAX,
                               PRECIO = insumo.PRECIO
                           };
            return insumos.ToList();
        }
    }
}
