using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Lupi.Data.Entities;
using Lupi.BusinessLogic;

namespace Lupi.UnitTest
{
    [TestClass]
    public class BreedUnitTest
    {
        [TestMethod]
        public void CreateBreed()
        {
            BreedBusinessLogic breeds = new BreedBusinessLogic();
            Guid id = System.Guid.NewGuid();
            String name = "Bulldog";
            String hairType = "";
            List<String> hairColor = new List<String>();
            hairColor.Add("White");

            Breed breed = new Breed(id,name,hairType,hairColor);

            breeds.Create(breed);

            Assert.IsTrue(breeds.Exists(breed.id));
        }

        [TestMethod]
        public void UpdateBreed()
        {
            BreedBusinessLogic breeds = new BreedBusinessLogic();
            var breed = CreateABreed();            
            var breedOldName = breed.name;
            breed.name = "Ovejero";

            breeds.Update(breed.id, breed);

            Assert.AreNotEqual(breedOldName,breed.name);
        }


        private Breed CreateABreed()
        {
            Guid id = System.Guid.NewGuid();
            String name = "Bulldog";
            String hairType = "";
            List<String> hairColor = new List<String>();
            hairColor.Add("White");

            Breed breed = new Breed(id, name, hairType, hairColor);
            return breed;
        }

    }
}
