namespace Modelo
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Auditoria : DbContext
    {
        public static Auditoria instancia;
        public static Auditoria OBTENER_INSTANCIA()
        {
            if (instancia == null)
            {
                instancia = new Auditoria();
            }
            return instancia;
        }
        public Auditoria()
            : base("name=Auditoria")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }
        public virtual DbSet<A_Insumo> A_INSUMOS { get; set; }
    }
}
