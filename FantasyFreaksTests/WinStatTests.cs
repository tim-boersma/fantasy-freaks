using DataAccess;
using DataAccess.Models;
using Fantasy_Freaks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static FantasyFreaksTests.TestingObjects;

namespace FantasyFreaksTests
{
    [TestClass]
    public class WinStatTests
    {
        static List<PlayerPerformanceDataModel> players = new List<PlayerPerformanceDataModel>();

        [ClassInitialize]
        public static void Setup(TestContext testContext)
        {
            players = new List<PlayerPerformanceDataModel>()
            {
                player1, player2, player3
            };
        }

        [TestMethod]
        [DataRow(250, 44)]
        [DataRow(315, 38)]
        [DataRow(350, 34)]
        [DataRow(420, 28)]
        [DataRow(490, 20)]
        public void CalculateScoreFromTotalPoints_ReturnsCorrectValue(int totalPoints, int expected)
        {
            Console.WriteLine(expected);
            //Act
            var result = WinStat.CalculateScoreFromTotalPoints(totalPoints);

            //Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        [DataRow(6000, 26)]
        [DataRow(5555, 32)]
        [DataRow(5222, 36)]
        [DataRow(4444, 46)]
        public void CalculateScoreFromTotalYards_ReturnsCorrectValue(int totalYards, int expected)
        {
            //Act
            var result = WinStat.CalculateScoreFromTotalYards(totalYards);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateOffensiveScore_ReturnsCorrectScore()
        {
            //Arrange
            var input = players;
            var expected = 250.55;

            //Act
            var result = WinStat.CalculateOffensiveScore(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(20, 15, 444, 6222, 138)]
        [DataRow(0, 0, 205, 5666,78)]
        [DataRow(15, 20, 277, 5333, 163)]
        [DataRow(45, 35, 399, 4666, 279)]
        public void CalculateDefensiveScore_ReturnsCorrectScore(int interceptions, int forcedFumbles, int pointsAlloweed, int totalYardsAllowed, int expectedScore)
        {
            //Arrange
            var team = new DefenseDataModel()
            {
                Interceptions = interceptions,
                ForcedFumbles = forcedFumbles,
                PointsAllowed = pointsAlloweed,
                TotalYardsAllowed = totalYardsAllowed
            };
            var expected = expectedScore;

            //Act
            var result = WinStat.CalculateDefensiveScore(team);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}