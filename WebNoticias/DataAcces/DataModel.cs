namespace DataAcces
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using DataAcces.Entitys;

    public class DataModel : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'DataModel' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'DataAcces.DataModel' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'DataModel'  en el archivo de configuración de la aplicación.
        public DataModel()
            : base("name=DataModel")
        {
        }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<News> News { get; set; }
    }
}