using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lupi.Data.Entities;

namespace Lupi.Data.DataAccess
{
    public class LupiContext : DbContext
    {
        public LupiContext():base("name=LupiDBConnectionString")
        {
            /*
            drops an existing database and creates a new database, if your model classes 
            (entity classes) have been changed. So, you don't have to worry about maintaining 
            your database schema, when your model classes change
            Más info en: http://www.entityframeworktutorial.net/code-first/database-initialization-strategy-in-code-first.aspx
            
            También es posible configurar todo esto en AppConfig. Se hace acá para que esté junto. Luego se puede cambiar.
            */
            Database.SetInitializer<LupiContext>(new DropCreateDatabaseIfModelChanges<LupiContext>());
        }
 
        public DbSet<Breed> Breeds { get; set; }
        public DbSet<Base64Image> Images { get; set; }
        public DbSet<Collar> Collars { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pet> Pets { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Acá va la configuración de FluentApi
            //Esquema por defecto
            modelBuilder.HasDefaultSchema("EsquemaLUPI");
            //Mapear Entidades
            modelBuilder.Entity<Breed>().ToTable("Breeds");
            modelBuilder.Entity<Base64Image>().ToTable("Images");
            modelBuilder.Entity<Collar>().ToTable("Collars");
            modelBuilder.Entity<Owner>().ToTable("Owners");
            modelBuilder.Entity<Pet>().ToTable("Pets");
            //Claves primarias
            modelBuilder.Entity<Breed>().HasKey(B => B.id);
            modelBuilder.Entity<Base64Image>().HasKey(B => B.Id);
            modelBuilder.Entity<Collar>().HasKey(C => C.Id);
            modelBuilder.Entity<Owner>().HasKey(O => O.Id);
            modelBuilder.Entity<Pet>().HasKey(P => P.Id);
            //Restricciones estructurales (relaciones).
            modelBuilder.Entity<Collar>().HasRequired<Owner>(c => c.Owner).WithMany(o => o.Collars).HasForeignKey(c => c.OwnerId);
            modelBuilder.Entity<Owner>().HasMany<Pet>(c => c.Pets);
            modelBuilder.Entity<Pet>().HasOptional<Collar>(P => P.AssignedCollar);
            modelBuilder.Entity<Pet>().HasRequired<Breed>(P => P.Breed);
            modelBuilder.Entity<Pet>().HasRequired<Base64Image>(P => P.Image);


           
           
        }
    }

}