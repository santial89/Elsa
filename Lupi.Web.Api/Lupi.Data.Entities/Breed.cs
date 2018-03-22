using System;
using System.Collections.Generic;

namespace Lupi.UnitTest
{
    internal class Breed
    {
        private List<string> hairColor;
        private string hairType;
        private Guid id;
        private string name;

        public Breed(Guid id, string name, string hairType, List<string> hairColor)
        {
            this.id = id;
            this.name = name;
            this.hairType = hairType;
            this.hairColor = hairColor;
        }
    }
}