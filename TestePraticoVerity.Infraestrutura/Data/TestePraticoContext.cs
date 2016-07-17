using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TestePraticoVerity.Dominio.Entidades;

namespace TestePraticoVerity.Infraestrutura.Data
{
    public class TestePraticoContext : DbContext
    {
        public TestePraticoContext()
        : base("TestePratico")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Produtos> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Produtos>().ToTable("Produtos");
            modelBuilder.Entity<Categoria>().ToTable("Categoria");
        }
    }
}
