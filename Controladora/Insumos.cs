using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class Insumos
    {
        public static Insumos instancia;
        public static Insumos OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new Insumos();
            }
            return instancia;
        }
        Modelo.Fabrica oFabrica;
        private Insumos()
        {
            oFabrica = Modelo.Fabrica.OBTENER_INSTANCIA();
        }
        //ABM
        public void AGREGAR_INSUMO(Modelo.Insumo oInsumo)
        {
            oFabrica.INSUMOS.Add(oInsumo);
            oFabrica.SaveChanges();
        }
        public void MODIFICAR_INSUMO(Modelo.Insumo oInsumo)
        {
            oFabrica.Entry(oInsumo).State = System.Data.Entity.EntityState.Modified;
            oFabrica.SaveChanges();
        }
        public void ELIMINAR_INSUMO(Modelo.Insumo oInsumo)
        {
            oFabrica.INSUMOS.Remove(oInsumo);
            oFabrica.SaveChanges();
        }
        //LISTAR
        public System.Collections.IEnumerable LISTAR_INSUMO(int cantidad = 10, string Codigo_Insumo = "", string Nombre = "")
        {
            var insumos = from insumo in oFabrica.INSUMOS.ToList()
                          where (insumo.NOMBRE_INSUMO.ToLower().Contains(Nombre.ToLower()) && (insumo.CODIGO_INSUMO.ToLower().Contains(Codigo_Insumo.ToLower())))
                          select new
                          {
                              CODIGO = insumo.CODIGO,
                              CODIGO_INSUMO = insumo.CODIGO_INSUMO,
                              NOMBRE_INSUMO = insumo.NOMBRE_INSUMO,
                              DETALLE = insumo.DETALLE,
                              STOCK_MIN = insumo.STOCK_MIN,
                              STOCK_MAX = insumo.STOCK_MAX,
                              PRECIO = insumo.PRECIO
                          };
            return insumos.Take(cantidad).ToList();
        }
        public System.Collections.IEnumerable LISTAR_INSUMO()
        {
            var insumos = from insumo in oFabrica.INSUMOS.ToList()
                          select new
                          {
                              CODIGO = insumo.CODIGO,
                              CODIGO_INSUMO = insumo.CODIGO_INSUMO,
                              NOMBRE_INSUMO = insumo.NOMBRE_INSUMO,
                              DETALLE = insumo.DETALLE,
                              STOCK = insumo.CANTIDAD,
                              STOCK_MIN = insumo.STOCK_MIN,
                              STOCK_MAX = insumo.STOCK_MAX,
                          };
            return insumos.ToList();
        }
        //BUSCAR
        public Modelo.Insumo BUSCAR_INSUMO(Int32 Codigo)
        {
            return oFabrica.INSUMOS.Find(Codigo);
        }
        public List<Modelo.Insumo> LISTAR()
        {
            return oFabrica.INSUMOS.ToList();
        }
       
    }
}
