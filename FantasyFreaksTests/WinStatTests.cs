using DataAccess;
using Fantasy_Freaks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WinStat_Unit_Test
{
    [TestClass]
    public class WinStatTests
    {
        [TestMethod]
        public void CalculateScoreFromTotalPoints_ReturnsCorrectValue()
        {
            //Arrange
            int totalPoints = 100;
            int expected = 48;

            //Act
            int result = WinStat.CalculateScoreFromTotalPoints(totalPoints);

            //Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void CalculateScoreFromTotalYards_ReturnsCorrectValue()
        {
            //Arrange
            int totalYards = 100;
            int expected = 46;

            //Act
            int result = WinStat.CalculateScoreFromTotalYards(totalYards);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}