using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Freaks {
    public class WinStat {

        public static int EventForDay() {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int num = rnd.Next(0, 5);
            return num;
        }

        public static int CalculateScoreFromTotalPoints(int PointsAllowed) {
            PointsAllowed -= 201;//lowest score
            int score = 0;
            while (PointsAllowed >= 0) {
                PointsAllowed = PointsAllowed - 20;//iteration = gap
                if (PointsAllowed >= 0)
                    score++;
            }
            return 48 - 2 * score;
        }

        public static int CalculateScoreFromTotalYards(int TotalYards) {
            TotalYards -= 4301;//lowest score
            int score = 0;
            while (TotalYards >= 0) {
                TotalYards = TotalYards - 150;//iteration = gap
                if (TotalYards >= 0)
                    score++;
            }
            return 46 - 2 * score;
        }

        public static int CalculateDefensiveScore(DefenseDataModel defTeam) 
        {
            return (int)((defTeam.Interceptions * 3) + (defTeam.ForcedFumbles * 2) + CalculateScoreFromTotalPoints((int)defTeam.PointsAllowed) + CalculateScoreFromTotalYards((int)defTeam.TotalYardsAllowed));
        }


        public static double CalculateOffensiveScore(PlayerPerformanceDataModel player) 
        {
            return (player.PassingTouchdowns * 4) + (player.RushingTouchdowns * 6) +
                (player.RecievingTouchdowns * 6) + (player.Receptions * 1) + (player.RushingYards * .1) +
                (player.RecievingYards * .1) + (player.PassingYards * .04) +
                (player.Interceptions * -3)
                + (player.Fumbles * -3);
        }

    }
}
