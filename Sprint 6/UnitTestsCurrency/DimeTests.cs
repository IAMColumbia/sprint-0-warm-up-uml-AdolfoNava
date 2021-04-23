using Currency.US;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestsCurrency
{
    [TestClass]
    public class DimeTests
    {
        Dime d;

        public DimeTests()
        {
            d = new Dime();
        }
        
        public void DimeConstructor()
        {
            //Arrange
            Dime philiDime;
            //Act 

            philiDime = new Dime(USCoinMintMark.P);
            //Assert
            Assert.AreEqual("D", d.MintMark); //D is the default mint mark
            Assert.AreEqual(System.DateTime.Now.Year, d.Year); //Current Year is default year

            Assert.Equals("P", philiDime.MintMark);

        }

        [TestMethod]
        public void PennyMonetaryValue()
        {
            //Arrange
            double dimeValue = .1;
            //Go ahead try a double
            //Act 
            
            //Assert
            Assert.AreEqual(dimeValue, d.MonetaryValue);
        }

        [TestMethod]
        public void DimeAbout()
        {
            //Arrange

            double dimeValue = .10;
            //Act 
            
            //Assert
            Assert.AreEqual($"US Dime is from { System.DateTime.Now.Year }. It is worth ${ dimeValue}. It was made in Denver", d.About());
        }

        [TestMethod]
        public void DimePortaitIsNotNull()
        {
            //Assert
            Assert.IsNotNull(d.Portait);
        }

        [TestMethod]
        public void DimeReverseMotifIsNotNull()
        {
            //Assert
            Assert.IsNotNull(d.ReverseMotif);
        }

        [TestMethod]
        public void DimePortraitDefaultValue()
        {
            //Arrange
            string expectedDimePortrait;
            //Act
            expectedDimePortrait = "Franklin D. Roosevelt";
            //Assert
            Assert.AreEqual(expectedDimePortrait, d.Portait);
        }

        [TestMethod]
        public void DimeReverseMotifDefaultValue()
        {
            //Arrange
            string expectedDimeReverseMotif;
            //Act
            expectedDimeReverseMotif = "torch, oak branch, olive branch";
            //Assert
            Assert.AreEqual(expectedDimeReverseMotif, d.ReverseMotif);
        }
    }
}
