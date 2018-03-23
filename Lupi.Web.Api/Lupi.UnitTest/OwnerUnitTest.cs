using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lupi.Data.Entities;

namespace Lupi.UnitTest
{
    [TestClass]
    public class OwnerUnitTest
    {
        [TestMethod]
        public void CreateOwner()
        {
            Owner owner = new Owner();
            var id = Guid.NewGuid();
            owner.Id = id;
            owner.Name = "Juan";
            owner.Mail = "juan@mail.com";
            owner.Password = "pfffff";
            owner.BirthDate = DateTime.Now;

            Assert.AreEqual(owner.Id,id);


        }
    }
}
