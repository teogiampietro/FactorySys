using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Controladora
{
    public class OrdenesFabricacion
    {
        public static OrdenesFabricacion instancia;
        public static OrdenesFabricacion OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new OrdenesFabricacion();
            }
            return instancia;
        }
        Modelo.Fabrica oFabrica;
        private OrdenesFabricacion()
        {
            oFabrica = Modelo.Fabrica.OBTENER_INSTANCIA();
        }
        public void AGREGAR_OF(Modelo.OrdenFabricacion oOrdenFabricacion)
        {
            oFabrica.ORDEN_FABRICACION.Add(oOrdenFabricacion);
            oFabrica.SaveChanges();
        }
        public void ELIMINAR_OF(Modelo.OrdenFabricacion oOrdenFabricacion)
        {
            oFabrica.ORDEN_FABRICACION.Remove(oOrdenFabricacion);
            oFabrica.SaveChanges();
        }
        public void MODIFICAR_OF(Modelo.OrdenFabricacion oOrdenFabricacion)
        {
            oFabrica.Entry(oOrdenFabricacion).State = System.Data.Entity.EntityState.Modified;
            oFabrica.SaveChanges();
        }
        public List<Modelo.Tarea> LISTAR_TAREA()
        {
            return oFabrica.TAREA.ToList();
        }
        public List<Modelo.Estado> LISTAR_ESTADOS()
        {
            return oFabrica.ESTADO.ToList();
        }
        public System.Collections.IEnumerable LISTAR_OF()
        {
            var ordenes = from orden in oFabrica.ORDEN_FABRICACION.Include(a=>a.PEDIDO.CLIENTE.LOCALIDAD).Include(b => b.USUARIO).Include(c => c.LINEA_OF).Include(d=>d.PEDIDO.LINEA_PEDIDO.Select(e=>e.PRODUCTO.LINEA_PRODUCTO.Select(f=>f.INSUMO))).Include(g=>g.ESTADO).ToList()
                          select new
                          {
                              CODIGO = orden.CODIGO_OF,
                              ENCARGADO = orden.USUARIO,
                              PEDIDO = orden.PEDIDO,
                              ESTADO = orden.ESTADO
                                                           
                          };
            return ordenes.ToList();
        }
        public Modelo.OrdenFabricacion BUSCAR_OF(Int32 CODIGO)
        {
            return oFabrica.ORDEN_FABRICACION.Find(CODIGO);
        }
        public List<Modelo.Insumo> LISTAR_INSUMOS(Modelo.Pedido oPedido)//armo la lista de insumos necesario para la realizacion de la of
        {
            List<Modelo.Insumo> Insumos = new List<Modelo.Insumo> ();
            foreach (Modelo.LineaPedido oProducto in oPedido.LINEA_PEDIDO.ToList())
            {
                foreach (Modelo.LineaProducto lineaProducto in oProducto.PRODUCTO.LINEA_PRODUCTO.ToList())
                {
                    Modelo.Insumo insumo = new Modelo.Insumo
                    {
                        CODIGO = lineaProducto.CODIGO_INSUMO,
                        CODIGO_INSUMO = lineaProducto.INSUMO.CODIGO_INSUMO,                    
                        NOMBRE_INSUMO = lineaProducto.INSUMO.NOMBRE_INSUMO,
                        CANTIDAD = (oProducto.CANTIDAD * lineaProducto.CANTIDAD),
                        DETALLE = lineaProducto.INSUMO.DETALLE
                    };
                    Insumos.Add(insumo);
                }
            }
            return Insumos;
        }
        public System.Collections.IEnumerable ARMAR_INSUMOS(List<Modelo.Insumo> Insumos) //ordeno y agrupo los insumos a mostrar
        {
            var productos = from linea in Insumos.ToList()
                            group linea by linea.CODIGO into a
                            select new
                            {
                                a.FirstOrDefault().CODIGO,
                                a.FirstOrDefault().CODIGO_INSUMO,
                                a.FirstOrDefault().NOMBRE_INSUMO,
                                a.FirstOrDefault().DETALLE,
                                Cantidad = a.Sum(x => Convert.ToInt32(x.CANTIDAD))
                            };
            return productos.ToList();
        }
    }
}
