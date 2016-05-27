using Microsoft.VisualStudio.TestTools.UnitTesting;
using Durgam_AbdulAmir_Uppgift3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durgam_AbdulAmir_Uppgift3.Tests
{
    [TestClass()]
    public class SpeedTests
    {
        [TestMethod()]
        public void CalSpeedTest_SpaceNumber()
        {
            //Arrange
            var cal = new Speed();
            //Act
            var actual = cal.CalSpeed(" 1000", " 100");
            var expected = 10;
            //Assert
            Assert.AreEqual(expected, actual, "Space + Value's");
        }

        [TestMethod()]
        public void CalSpeedTest_NumberSpace()
        {
            //Arrange
            var cal = new Speed();
            //Act
            var actual = cal.CalSpeed("1000 ", "100 ");
            var expected = 10;
            //Assert
            Assert.AreEqual(expected, actual, "Value's + Space");
        }

        [TestMethod()]
        public void CalSpeedTest_NumberText()
        {
            //Arrange
            var cal = new Speed();
            //Act
            cal.CalSpeed("1000km", " 100h");
            //Assert
        }



    }
}