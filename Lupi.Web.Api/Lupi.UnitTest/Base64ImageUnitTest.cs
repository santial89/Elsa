using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        public void CrearCrearInstancia()
        {
            //Arrange
            Base64Image imagen; 
            //Act
            imagen= new Base64Image();
            //Assert
            Assert.IsNotNull(imagen);
        }
    }
}
