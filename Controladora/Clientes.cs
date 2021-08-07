using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class Clientes
    {
        public static Clientes instancia;
        public static Clientes OBTENER_INSTANCIA()
        {
            if (instancia == null )
            {
                instancia = new Clientes();
            }
            return instancia;
        }
        Modelo.Fabrica oFabrica;
        public Clientes()
        {
            oFabrica = Modelo.Fabrica.OBTENER_INSTANCIA();
        }
        //ABM
        public void AGREGAR_CLIENTE(Modelo.Cliente oCliente)
        {
            oFabrica.CLIENTES.Add(oCliente);
            oFabrica.SaveChanges();
        }
        public void ELIMINAR_CLIENTE(Modelo.Cliente oCliente)
        {
            oFabrica.CLIENTES.Remove(oCliente);
            oFabrica.SaveChanges();
        }
        public void MODIFICAR_CLIENTE(Modelo.Cliente oCliente)
        {
            oFabrica.Entry(oCliente).State = System.Data.Entity.EntityState.Modified;
            oFabrica.SaveChanges();
        }
        public System.Collections.IEnumerable LISTAR_CLIENTES(int cantidad = 10 , string DNI = "", string Nombre = "",  string Email = "")//toma como parametros default, entonces me trae todas las busquedas.
        {
            var clientes = from cliente in oFabrica.CLIENTES.Include("Localidad").ToList()
                           where (cliente.NOMBRE.ToLower().Contains(Nombre.ToLower()) && (cliente.DNI.ToLower().Contains(DNI.ToLower())) && cliente.EMAIL.ToLower().Contains(Email.ToLower()))
                           select new
                           {
                                  CODIGO = cliente.CODIGO_CLIENTE,
                                  DNI = cliente.DNI,
                                  NOMBRE = cliente.NOMBRE,
                                  DIRECCION = cliente.DIRECCION,
                                  LOCALIDAD = cliente.LOCALIDAD,
                                  TELEFONO = cliente.TELEFONO,
                                  EMAIL = cliente.EMAIL,
                                  CATEGORIA = cliente.CATEGORIA,
                              };
            return clientes.Take(cantidad).ToList();
        }
        public System.Collections.IEnumerable LISTAR_CLIENTES()//toma como parametros default, entonces me trae todas las busquedas.
        {
            var clientes = from cliente in oFabrica.CLIENTES.Include("Localidad").ToList()                         
                           select new
                           {
                               CODIGO = cliente.CODIGO_CLIENTE,
                               DNI = cliente.DNI,
                               NOMBRE = cliente.NOMBRE,
                               DIRECCION = cliente.DIRECCION,
                               LOCALIDAD = cliente.LOCALIDAD,
                               TELEFONO = cliente.TELEFONO,
                               EMAIL = cliente.EMAIL,
                               CATEGORIA = cliente.CATEGORIA,
                           };
            return clientes.Take(10).ToList();
        }
        public Modelo.Cliente BUSCAR_CLIENTE(Int32 Codigo)
        {
            return oFabrica.CLIENTES.Find(Codigo);
        }    
    }
}
