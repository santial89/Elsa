using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lupi.Data.Entities
{
    public class Collar
    {
        public Guid Id  { get; set; }
        
        public Owner Owner { get; set; }
        //Para usar con FluentApi en la persistencia
        public Guid OwnerId { get; set; }
    }
}
