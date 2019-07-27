using System;
using TestToka.Data.Entities;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestToka.Data
{
    public class TestTokaDbContext : DbContext
    {
        public TestTokaDbContext() : base("name=WebAppEntities")
        {
            Database.SetInitializer(new TestTokaInitializer());
        }
        protected override void OnModelCreating(DbModelBuilder builder)
        {

            //userinfo
            builder.Entity<Auto>().ToTable("Autos");
            builder.Entity<Solicitud>().ToTable("Solicitudes");
            builder.Entity<DetalleSolicitud>().ToTable("DetalleSolicitudes");
            
            base.OnModelCreating(builder);
        }

        

        public DbSet<Auto> Auto { get; set; }
        public DbSet<Solicitud> Solicitud { get; set; }
        public DbSet<DetalleSolicitud> DetalleSolicitud { get; set; }
    }
}
