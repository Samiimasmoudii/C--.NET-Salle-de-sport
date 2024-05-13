using MySql.Data.EntityFramework;
using System.Data.Entity;


namespace ProjetC_MVCSalleSport.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ContexteDeBaseDeDonnees : DbContext
    {
        public ContexteDeBaseDeDonnees() : base("ConnectionString")
        {
        }

        public DbSet<Membre> Membres { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public DbSet<Cours> Cours { get; set; }

        public DbSet<Progrés> Progres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurez ici le mapping des entités si nécessaire
            // modelBuilder.Entity<YourEntity>().ToTable("YourTableName");
        }
    }
}