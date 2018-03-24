using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lupi.Data.Entities;

namespace Lupi.UnitTest
{
    [TestClass]
    public class PetUnitTest
    {
        [TestMethod]
        public void PetCrearInstanciaOK()
        {
            //Arrange
            Pet aPet;
            //Act
            aPet = new Pet();
            //Assert
            Assert.IsNotNull(aPet);
        }
        [TestMethod]
        public void PetPropertiesGuidOK()
        {
            //Arrange
            Guid unGuid = new Guid();
            Pet aPet = new Pet();
            //Act
            aPet.Id = unGuid;
            //Assert
            Assert.AreEqual(aPet.Id, unGuid);
        }
        [TestMethod]
        public void PetPropertiesNameOK()
        {
            //Arrange
            String unNombre = "UNNOMBRE";
            Pet aPet = new Pet();
            //Act
            aPet.Name = unNombre;
            //Assert
            Assert.AreEqual(aPet.Name, unNombre);
        }
        [TestMethod]
        public void PetPropertiesAgeOK()
        {
            //Arrange
            int unaEdad = 2;
            Pet aPet = new Pet();
            //Act
            aPet.Age = unaEdad;
            //Assert
            Assert.AreEqual(aPet.Age, unaEdad);
        }
        [TestMethod]
        public void PetPropertiesSizeOK()
        {
            //Arrange
            String unTamanio = "UNTAMANIO";
            Pet aPet = new Pet();
            //Act
            aPet.Size = unTamanio;
            //Assert
            Assert.AreEqual(aPet.Size, unTamanio);
        }
        [TestMethod]
        public void PetPropertiesBrithDayOK()
        {
            //Arrange
            Pet aPet = new Pet();
            DateTime unaFecha=DateTime.Now; ;
            //Act
            aPet.BirthDay = unaFecha;
            //Assert
            Assert.AreEqual(aPet.BirthDay, unaFecha);
        }
    }
}
