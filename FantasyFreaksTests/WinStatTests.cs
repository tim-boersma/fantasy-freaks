using Fantasy_Freaks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WinStat_Unit_Test
{
    [TestClass]
    public class WinStatTests
    {
        [TestMethod]
        public void TestPoints()
        {
            int result, PointsAllowed, actual;
            int score;
            for (int i = 100; i <= 1000; i += 50)
            {
                result = Fantasy_Freaks.WinStat.CalculateScoreFromTotalPoints(i);

                PointsAllowed = i - 201;
                score = 0;
                while (PointsAllowed >= 0)
                {
                    PointsAllowed = PointsAllowed - 20;
                    if (PointsAllowed >= 0)
                        score++;
                }
                actual = 48 - 2 * score;

                Assert.IsTrue(result == actual);
            }
        }

        [TestMethod]
        public void TestYards()
        {
            int result, TotalYards, actual;
            int score;
            for (int i = 100; i <= 1000; i += 50)
            {
                result = Fantasy_Freaks.WinStat.CalculateScoreFromTotalYards(i);

                TotalYards = i - 4301;
                score = 0;
                while (TotalYards >= 0)
                {
                    TotalYards = TotalYards - 150;
                    if (TotalYards >= 0)
                        score++;
                }
                actual = 46 - 2 * score;

                Assert.IsTrue(result == actual);
            }
        }
    }
}