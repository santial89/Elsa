﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lupi.Data.Entities;

namespace Lupi.BusinessLogic
{
    public class BreedBusinessLogic
    {
        private List<Breed> breeds { get; set; }
        
        public BreedBusinessLogic()
        {
            breeds = new List<Breed>();
        }
         
        public void Create(Breed breed)
        {
            breeds.Add(breed);
            
        }

        public bool Exists(Guid id)
        {
            return breeds.Exists(b => b.id == id);
        }

        public void Update(Guid id, Breed updateBreed)
        {
            var breed = breeds.Find(b => b.id == id);
//            breed.hairColor = updateBreed.hairColor;
            breed.hairType = updateBreed.hairType;
            breed.name = updateBreed.name;

        }
    }
}
