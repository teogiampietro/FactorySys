namespace Modelo
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Fabrica : DbContext
    {
        public static Fabrica instancia;
        public static Fabrica OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new Fabrica();
            }
            return instancia;
        }
        public Fabrica()
            : base("name=FABRICA")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }
        #region SEGURIDAD
        public virtual DbSet<Usuario> USUARIOS { get; set; }
        public virtual DbSet<Grupo> GRUPOS { get; set; }
        public virtual DbSet<Formulario> FORMULARIO { get; set; }
        public virtual DbSet<Permiso> PERMISO { get; set; }
        public virtual DbSet<LogInOut> LOGINOUT { get; set; }
        #endregion
        #region PAIS_PROVINCIA_LOCALIDAD
        public virtual DbSet<Pais> PAIS { get; set; }  
        public virtual DbSet<Provincia> PROVINCIA { get; set; }
        public virtual DbSet<Localidad> LOCALIDAD { get; set; }
        #endregion
        #region ALMACEN
        public virtual DbSet<Insumo> INSUMOS { get; set; }
        public virtual DbSet<Proveedor> PROVEEDORES { get; set; }
        public virtual DbSet<OrdenCompra> ORDENCOMPRA { get; set; }
        public virtual DbSet<Remito> REMITO { get; set; }
        public virtual DbSet<Entrega> ENTREGA { get; set; }
        #endregion
        #region PRODUCCION
        public virtual DbSet<Cliente> CLIENTES { get; set; }
        public virtual DbSet<Producto> PRODUCTOS { get; set; }
        public virtual DbSet<Tipo> TIPO { get; set; }
        public virtual DbSet<Pedido> PEDIDOS { get; set; }
        public virtual DbSet<OrdenFabricacion> ORDEN_FABRICACION { get; set; }
        public virtual DbSet<Tarea> TAREA { get; set; }
        public virtual DbSet<Estado> ESTADO { get; set; }
        
        #endregion
        
    }
}

