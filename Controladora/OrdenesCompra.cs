using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Controladora
{
    public class OrdenesCompra
    {
        public static OrdenesCompra instancia;
        public static OrdenesCompra OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new OrdenesCompra();
            }
            return instancia;
        }
        Modelo.Fabrica oFabrica;
        private OrdenesCompra()
        {
            oFabrica = Modelo.Fabrica.OBTENER_INSTANCIA();
        }
        //ABM
        public void AGREGAR_ORDENDECOMPRA(Modelo.OrdenCompra oOrdenCompra)
        {
            oFabrica.ORDENCOMPRA.Add(oOrdenCompra);
            oFabrica.SaveChanges();
        }
        public void ELIMINAR_ORDENCOMPRA(Modelo.OrdenCompra oOrdenCompra)
        {
            oFabrica.ORDENCOMPRA.Remove(oOrdenCompra);
            oFabrica.SaveChanges();
        }
        public void MODIFICAR_ORDENCOMPRA(Modelo.OrdenCompra oOrdenCompra, ICollection<Modelo.LineaOrdenCompra> Lineas_Eliminar)
        {
            foreach(Modelo.LineaOrdenCompra Linea in Lineas_Eliminar.ToList())
            {
                oFabrica.Entry(Linea).State = EntityState.Deleted;
            }
            oFabrica.Entry(oOrdenCompra).State = EntityState.Modified;
            oFabrica.SaveChanges();
        }
        //LISTAR OC
        public System.Collections.IEnumerable LISTAR_ORDENCOMPRA(DateTime max, DateTime min, bool Verificado, string PROVEEDOR = "", int? codigo = null)
        {
            var ordenes = from orden in oFabrica.ORDENCOMPRA.Include("Proveedor").Include(a => a.LINEAOC.Select(b => b.INSUMO)).Include(c => c.LINEAOC.Select(d => d.ENTREGA)).ToList()
                          where (
                          (orden.FECHA_EMISION <= max && orden.FECHA_EMISION >= min)
                                && (orden.PROVEEDOR.NOMBRE.ToString().ToLower().Contains(PROVEEDOR.ToLower()) || PROVEEDOR == string.Empty)
                                && (orden.VERIFICADO == Verificado)
                                && (orden.CODIGO_ORDEN == codigo || codigo == null)
                               )
                          select new
                          {
                              CODIGO = orden.CODIGO_ORDEN,
                              PROVEEDOR = orden.PROVEEDOR,
                              DIRECCION = orden.PROVEEDOR.DIRECCION,
                              TELEFONO = orden.PROVEEDOR.TELEFONO,
                              FECHA = orden.FECHA_EMISION,
                              VERIFICADO = orden.VERIFICADO,
                              ESTADO = orden.ESTADO,
                              TOTAL = orden.TOTAL
                          };
            return ordenes.ToList();
        }
        public System.Collections.IEnumerable OBTENER_ORDENES()
        {
            var ordenes = from orden in oFabrica.ORDENCOMPRA.Include("Proveedor").Include(a => a.LINEAOC.Select(b => b.INSUMO)).Include(c => c.LINEAOC.Select(d => d.ENTREGA)).ToList()
                          select new
                          {
                              CODIGO = orden.CODIGO_ORDEN,
                              PROVEEDOR = orden.PROVEEDOR,
                              DIRECCION = orden.PROVEEDOR.DIRECCION,
                              TELEFONO = orden.PROVEEDOR.TELEFONO,
                              FECHA = orden.FECHA_EMISION,
                              VERIFICADO = orden.VERIFICADO,
                              ESTADO = orden.ESTADO,
                              TOTAL = orden.TOTAL
                          };
            return ordenes.ToList();
        }
        public Modelo.OrdenCompra BUSCAR_OC(Int32 CODIGO)
        {
            return oFabrica.ORDENCOMPRA.Find(CODIGO);
        }
        public List<Modelo.Entrega> LISTAR_ENTREGA()
        {
            return oFabrica.ENTREGA.ToList();
        }
    }   
}
