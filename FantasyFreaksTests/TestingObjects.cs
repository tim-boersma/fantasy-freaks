using DataAccess.Models;

namespace FantasyFreaksTests
{
    public static class TestingObjects
    {
        public static PlayerPerformanceDataModel player1 = new PlayerPerformanceDataModel()
        {
            PassingTouchdowns = 1,
            RushingTouchdowns = 2,
            RecievingTouchdowns = 3,
            Receptions = 4,
            RushingYards = 50,
            RecievingYards = 60,
            PassingYards = 70,
            Interceptions = 8,
            Fumbles = 9
        };

        public static PlayerPerformanceDataModel player2 = new PlayerPerformanceDataModel()
        {
            PassingTouchdowns = 9,
            RushingTouchdowns = 8,
            RecievingTouchdowns = 7,
            Receptions = 6,
            RushingYards = 50,
            RecievingYards = 40,
            PassingYards = 30,
            Interceptions = 2,
            Fumbles = 1
        };

        public static PlayerPerformanceDataModel player3 = new PlayerPerformanceDataModel()
        {
            PassingTouchdowns = 7,
            RushingTouchdowns = 2,
            RecievingTouchdowns = 6,
            Receptions = 1,
            RushingYards = 100,
            RecievingYards = 50,
            PassingYards = 80,
            Interceptions = 9,
            Fumbles = 3
        };
    }
}
