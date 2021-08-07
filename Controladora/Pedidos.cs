using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Controladora
{
    public class Pedidos
    {
        public static Pedidos instancia;
        public static Pedidos OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new Pedidos();
            }
            return instancia;
        }
        Modelo.Fabrica oFabrica;
        public Pedidos()
        {
            oFabrica = Modelo.Fabrica.OBTENER_INSTANCIA();
        }
        //ABM
        public void AGREGAR_PEDIDO(Modelo.Pedido oPedido)
        {
            oFabrica.PEDIDOS.Add(oPedido);
            oFabrica.SaveChanges();
        }
        public void ELIMINAR_PEDIDO(Modelo.Pedido oPedido)
        {
            oFabrica.PEDIDOS.Remove(oPedido);
            oFabrica.SaveChanges();
        }
        public void MODIFICAR_PEDIDO(Modelo.Pedido oPedido)
        {
            oFabrica.Entry(oPedido).State = System.Data.Entity.EntityState.Modified;
            oFabrica.SaveChanges();
        }
        public System.Collections.IEnumerable LISTAR_PEDIDOS()
        {
            var pedidos = from pedido in oFabrica.PEDIDOS.Include(a => a.CLIENTE.LOCALIDAD).Include(b => b.LINEA_PEDIDO.Select(c=>c.PRODUCTO)).ToList()                          
                          select new
                          {
                              CODIGO = pedido.CODIGO_PEDIDO,
                              CLIENTE = pedido.CLIENTE,
                              FECHA = pedido.FECHA_ENTREGA,
                              COSTO_TOTAL = pedido.COSTO_TOTAL,
                              TOTAL = pedido.TOTAL
                          };
            return pedidos.ToList();                          
        }
        public System.Collections.IEnumerable LISTAR_PEDIDOS(string CLIENTE = "", int? CODIGO = null)
        {
            var pedidos = from pedido in oFabrica.PEDIDOS.Include(a => a.CLIENTE.LOCALIDAD).Include(b => b.LINEA_PEDIDO.Select(c => c.PRODUCTO)).ToList()
                          where (pedido.CODIGO_PEDIDO == CODIGO || CODIGO == null) && (pedido.CLIENTE.NOMBRE.ToLower().Contains(CLIENTE.ToLower()))
                          select new
                          {
                              CODIGO = pedido.CODIGO_PEDIDO,
                              CLIENTE = pedido.CLIENTE,
                              FECHA = pedido.FECHA_ENTREGA,
                              COSTO_TOTAL = pedido.COSTO_TOTAL,
                              TOTAL = pedido.TOTAL
                          };
            return pedidos.ToList();
        }
        public Modelo.Pedido BUSCAR_PEDIDO(Int32 Codigo)
        {
            return oFabrica.PEDIDOS.Include(d => d.LINEA_PEDIDO).Where(e => e.CODIGO_PEDIDO == Codigo).Include(f=> f.LINEA_PEDIDO.Select(g=>g.PRODUCTO.LINEA_PRODUCTO.Select(h=>h.INSUMO))).FirstOrDefault();
        }
    }
}