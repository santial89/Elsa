using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lupi.Data.Entities
{
    public class Owner
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Mail { get; set; }
        public String Password { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Collar> Collars { get; set; }
        public ICollection<Pet> Pets { get; set; }
    }
}
