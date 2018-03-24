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
            DateTime unaFecha=DateTime.Now; 
            //Act
            aPet.BirthDay = unaFecha;
            //Assert
            Assert.AreEqual(aPet.BirthDay, unaFecha);
        }
        [TestMethod]
        public void PetPropertiesWeightOK()
        {
            //Arrange
            Pet aPet = new Pet();
            Double unPeso = 14.4;
            //Act
            aPet.Weight = unPeso;
            //Assert
            Assert.AreEqual(aPet.Weight, unPeso);
        }
        [TestMethod]
        public void PetPropertiesImageOK()
        {
            //Arrange
            Pet aPet = new Pet();
            Base64Image unaImagen = new Base64Image();
            Guid unGuid = new Guid();
            unaImagen.Id = unGuid;
            unaImagen.Base64EncodedImage = "UNAIMAGEN";
            //Act
            aPet.Image = unaImagen;
            //Assert
            Assert.AreEqual(aPet.Image.Id, unGuid);
        }
        [TestMethod]
        public void PetPropertiesBreedOK()
        {
            //Arrange
            Pet aPet = new Pet();
            Breed unaBreed = new Breed();
            Guid unGuid = new Guid();
            unaBreed.id = unGuid;
            
            //Act
            aPet.Breed = unaBreed;
            //Assert
            Assert.AreEqual(aPet.Breed.id, unGuid);
        }
    }
}
