using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lupi.Data.Entities;

namespace Lupi.UnitTest
{
    /// <summary>
    /// Descripción resumida de Base64Image
    /// </summary>
    [TestClass]
    public class Base64ImageUnitTest
    {
        public Base64ImageUnitTest()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }
        [TestMethod]
        public void CrearInstancia()
        {
            //Arrange
            Base64Image imagen;
            //Act
            imagen = new Base64Image();
            //Assert
            Assert.IsNotNull(imagen);
        }
        [TestMethod]
        public void SetGetIdUnitTestOK()
        {
            //Arrange
            Guid unGuid = new Guid();
            Base64Image imagen = new Base64Image();
            //Act
            imagen.Id = unGuid;
            //Assert
            Assert.AreEqual(unGuid, imagen.Id);
        }
   
       [TestMethod]
       public void SetGetBase64EncodedImageTestOK()
        {
            //Arrange
            Guid unGuid = new Guid();
            String imagenCodificada = "IMAGENCODIFICADA";
            Base64Image imagen = new Base64Image();
            imagen.Id = unGuid;
            //Act
            imagen.Base64EncodedImage = imagenCodificada;
            //Assert
            Assert.AreEqual(imagenCodificada, imagen.Base64EncodedImage);

        }

    }
}
