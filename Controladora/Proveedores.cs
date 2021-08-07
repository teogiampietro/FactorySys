using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class Proveedores
    {
        public static Proveedores instancia;
        public static Proveedores OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new Proveedores();
            }
            return instancia;
        }
        Modelo.Fabrica oFabrica;
        private Proveedores()
        {
            oFabrica = Modelo.Fabrica.OBTENER_INSTANCIA();
        }
        #region ABM
        //ABM
        public void AGREGAR_PROVEEDOR(Modelo.Proveedor oProveedor)
        {
            oFabrica.PROVEEDORES.Add(oProveedor);
            oFabrica.SaveChanges();
        }
        public void ELIMINAR_PROVEEDOR(Modelo.Proveedor oProveedor)
        {
            oFabrica.PROVEEDORES.Remove(oProveedor);
            oFabrica.SaveChanges();
        }
        public void MODIFICAR_PROVEEDOR(Modelo.Proveedor oProveedor)
        {
            oFabrica.Entry(oProveedor).State = System.Data.Entity.EntityState.Modified;
            oFabrica.SaveChanges();
        }
        #endregion
        //LISTAR
        public System.Collections.IEnumerable LISTAR_PROVEEDORES(int cantidad = 10, string Nombre = "", string Cuit = "")//toma como parametros default, entonces me trae todas las busquedas.
        {
            var proveedores = from proveedor in oFabrica.PROVEEDORES.Include("Localidad").ToList()
                              where (proveedor.NOMBRE.ToLower().Contains(Nombre.ToLower()) && proveedor.CUIT.ToLower().Contains(Cuit.ToLower()))
                              select new
                              {
                                  CODIGO = proveedor.CODIGO_PROVEEDOR,
                                  CUIT = proveedor.CUIT,
                                  NOMBRE = proveedor.NOMBRE,
                                  DIRECCION = proveedor.DIRECCION,
                                  LOCALIDAD = proveedor.LOCALIDAD,
                                  TELEFONO = proveedor.TELEFONO,
                                  CELULAR = proveedor.CELULAR,
                                  EMAIL = proveedor.EMAIL,
                              };
            return proveedores.Take(cantidad).ToList();

        }

        //BUSCAR
        public Modelo.Proveedor BUSCAR_PROVEEDOR(Int32 Codigo)
        {
            return oFabrica.PROVEEDORES.Find(Codigo);
        }
        //Pais
        public List<Modelo.Pais> LISTAR_PAIS()
        {
            return oFabrica.PAIS.ToList();
        }
        //Provincias
        public List<Modelo.Provincia> LISTAR_PROVINCIAS(int Index)
        {
            string query = ("select * from PROVINCIAS where CODIGO_PAIS =" + Index);
            return oFabrica.PROVINCIA.SqlQuery(query).ToList();
        }
        //Localidades
        public List<Modelo.Localidad> LISTAR_LOCALIDAD(int Index)
        {
            string query = ("select * from LOCALIDADES where CODIGO_PROVINCIA =" + Index);
            return oFabrica.LOCALIDAD.SqlQuery(query).ToList();
        }

    }
}
