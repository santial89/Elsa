using System;
using System.Collections.Generic;

namespace Lupi.Data.Entities
{
    public class Breed
    {
        public List<string> hairColor { get; set; }
        public string hairType { get; set; }
        public Guid id { get; set; }
        public string name { get; set; }

        public Breed(Guid id, string name, string hairType, List<string> hairColor)
        {
            this.id = id;
            this.name = name;
            this.hairType = hairType;
            this.hairColor = hairColor;
        }
    }
}