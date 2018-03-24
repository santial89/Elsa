using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lupi.Data.Entities;

namespace Lupi.UnitTest
{
    [TestClass]
    public class CollarUnitTest
    {
        [TestMethod]
        public void CrearInstancia()
        {
            //Arrange
            Collar unCollar;
            bool tmpIsNull = false;
            //Act
             unCollar = new Collar();
            if (unCollar==null)
            {
                tmpIsNull = true;
            }
            //Assert
            Assert.IsFalse(tmpIsNull);
        }
        [TestMethod]
        public void CollarTieneGuidOK ()
        {
            //Arrange
             Collar tmpCollar = new Collar();
             Guid tmpGuid;
             bool tmpGuidNull=false;
            //Act
            tmpGuid = tmpCollar.Id;
            if (tmpGuid==null)
            {
                tmpGuidNull = true;
            }
            //Assert
            Assert.IsFalse(tmpGuidNull);
        }
        [TestMethod]
        public void CollarSetGuidOK()
        {
            //Arrange
            Guid tmpGuid = Guid.NewGuid();
            Collar unCollar = new Collar();
            unCollar.Id = tmpGuid;
            Guid tmpResultadoGuid;

            //Act
            tmpResultadoGuid = unCollar.Id;

            //Assert
            Assert.AreEqual(tmpResultadoGuid, tmpGuid);


        }
    }
}
