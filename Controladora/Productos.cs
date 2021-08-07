using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Controladora
{
    public class Productos
    {
        public static Productos instancia;
        public static Productos OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new Productos();
            }
            return instancia;
        }
        Modelo.Fabrica oFabrica;
        public Productos()
        {
            oFabrica = Modelo.Fabrica.OBTENER_INSTANCIA();
        }
        //ABM
        public void AGREGAR_PRODUCTO(Modelo.Producto oProducto)
        {
            oFabrica.PRODUCTOS.Add(oProducto);
            oFabrica.SaveChanges();
        }
        public void ELIMINAR_PRODUCTO(Modelo.Producto oProducto)
        {
            oFabrica.PRODUCTOS.Remove(oProducto);
            oFabrica.SaveChanges();
        }
        public void MODIFICAR_PRODUCTO(Modelo.Producto oProducto)
        {
            oFabrica.Entry(oProducto).State = System.Data.Entity.EntityState.Modified;
            oFabrica.SaveChanges();
        }
        public System.Collections.IEnumerable LISTAR_PRODUCTOS(int cantidad = 10, string codigo = "", string nombre = "")
        {
            var productos = from producto in oFabrica.PRODUCTOS.Include(a => a.LINEA_PRODUCTO.Select(b => b.INSUMO)).Include(c => c.TIPO).ToList()
                            where producto.CODIGO.ToLower().Contains(codigo.ToLower()) && producto.DESCRIPCION.ToLower().Contains(nombre.ToLower())
                            select new
                            {
                                CODIGO = producto.CODIGO_PRODUCTO,
                                PRODUCTO = producto.CODIGO,
                                DESCRIPCION = producto.DESCRIPCION,
                                TIPO = producto.TIPO,
                                COSTO_PRODUCTO = producto.COSTO_PRODUCTO
                                
                            };
            return productos.Take(cantidad).ToList();
        }
        public System.Collections.IEnumerable LISTAR_PRODUCTOS()
        {
            var productos = from producto in oFabrica.PRODUCTOS.Include(a=>a.LINEA_PRODUCTO.Select(b=>b.INSUMO)).Include(c=>c.TIPO).ToList()
                          select new
                          {
                              CODIGO = producto.CODIGO_PRODUCTO,
                              PRODUCTO = producto.CODIGO,
                              DESCRIPCION = producto.DESCRIPCION,
                              TIPO = producto.TIPO,
                              COSTO_PRODUCTO = producto.COSTO_PRODUCTO
                              
                          };
            return productos.Take(10).ToList();
        }
        public Modelo.Producto BUSCAR_PRODUCTO(Int32 Codigo)
        {
            return oFabrica.PRODUCTOS.Find(Codigo);
        }
        public List<Modelo.Tipo> LISTAR_TIPOS()
        {
            return oFabrica.TIPO.ToList();
        }
    }
}
