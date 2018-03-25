using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lupi.Data.Entities;

namespace Lupi.Data.DataAccess
{
    public class LupiDbContext : DbContext
    {
        public LupiDbContext() : base("name=Lupi") { }

        public DbSet<Breed> Breeds { get; set; }
        public DbSet<Base64Image> Images { get; set; }
        public DbSet<Collar> Collars { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pet> Pets { get; set; }
    }
}