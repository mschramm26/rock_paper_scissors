using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddPositiveNumbers() 
        {
            // Arrange
            Addition add = new Addition();
            double firstValue = 1;
            double secondValue = 2;
            double expectedResult = firstValue + secondValue;
            double actualResult;

            // Act
            actualResult = add.Calculate(firstValue, secondValue);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }


    }





    }
}
