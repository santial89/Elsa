﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lupi.Data.Entities
{
    public class Pet
    {
        public int Age { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
    }
}
