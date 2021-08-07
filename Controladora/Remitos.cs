using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Controladora
{
    public class Remitos
    {
        public static Remitos instancia;
        public static Remitos OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new Remitos();
            }
            return instancia;
        }
        Modelo.Fabrica oFabrica;
        private Remitos()
        {
            oFabrica = Modelo.Fabrica.OBTENER_INSTANCIA();
        }
        //ABM
        public void AGREGAR_REMITO(Modelo.Remito oRemito)
        {
            oFabrica.REMITO.Add(oRemito);
            oFabrica.SaveChanges();
        }
        public void ELMINAR_REMITO(Modelo.Remito oRemito)
        {
            foreach (var Linea in oRemito.LINEA_REMITO.ToList())
            {
                oFabrica.Entry(Linea).State = EntityState.Deleted;
            }
            oFabrica.Entry(oRemito).State = System.Data.Entity.EntityState.Deleted;            
            oFabrica.SaveChanges();           
        }
        public void MODIFICAR_REMITO(Modelo.Remito oRemito)
        {
            oFabrica.Entry(oRemito).State = System.Data.Entity.EntityState.Modified;
            oFabrica.SaveChanges();
        }
        public System.Collections.IEnumerable LISTAR_REMITOS()
        {
            var remitos = from remito in oFabrica.REMITO.Include(a => a.LINEA_REMITO.Select(b => b.INSUMO)).Include(d => d.ORDEN.PROVEEDOR).Include(d => d.ORDEN).Include(e=>e.LINEA_REMITO.Select(f=>f.ENTREGA)).ToList()
                          select new
                          {
                              CODIGO_REMITO = remito.CODIGO_REMITO,
                              CODIGO_ORDEN = remito.ORDEN.CODIGO_ORDEN,
                              PROVEEDOR = remito.ORDEN.PROVEEDOR,
                              FECHA = remito.FECHA_ENTREGA,
                              TOTAL = remito.TOTAL
                          };
            return remitos.ToList();
        }
        public System.Collections.IEnumerable LISTAR_REMITOS( DateTime min, DateTime max, string proveedor = "", int? codigo = null)
        {
            var remitos = from remito in oFabrica.REMITO.Include(a => a.LINEA_REMITO.Select(b => b.INSUMO)).Include(c => c.ORDEN.PROVEEDOR).Include(d => d.ORDEN).Include(e => e.LINEA_REMITO.Select(f => f.ENTREGA)).ToList()
                          where (
                          
                          (remito.FECHA_ENTREGA <= max && remito.FECHA_ENTREGA >= min) 
                          && (remito.ORDEN.PROVEEDOR.NOMBRE.ToLower().Contains(proveedor.ToLower()) || proveedor == string.Empty)
                          && (remito.CODIGO_REMITO == codigo || codigo == null)
                          )
                          select new
                          {
                              CODIGO_REMITO = remito.CODIGO_REMITO,
                              CODIGO_ORDEN = remito.ORDEN.CODIGO_ORDEN,
                              PROVEEDOR = remito.ORDEN.PROVEEDOR,
                              FECHA = remito.FECHA_ENTREGA,
                              TOTAL = remito.TOTAL
                          };
            return remitos.ToList();
        }
        public Modelo.Remito BUSCAR_REMITO(Int32 CODIGO)
        {
            return oFabrica.REMITO.Find(CODIGO);
        }

        public List<Modelo.Entrega> LISTAR_ENTREGA()
        {
            return oFabrica.ENTREGA.ToList();
        }
    }
}
