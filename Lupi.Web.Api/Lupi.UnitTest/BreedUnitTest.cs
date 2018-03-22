using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Lupi.Data.Entities;

namespace Lupi.UnitTest
{
    [TestClass]
    public class BreedUnitTest
    {
        [TestMethod]
        public void CreateBreed()
        {
            Guid id = System.Guid.NewGuid();
            String name = "Bulldog";
            String hairType = "";
            List<String> hairColor = new List<String>();
            hairColor.Add("White");

            Breed breed = new Breed(id,name,hairType,hairColor);
        }
    }
}
