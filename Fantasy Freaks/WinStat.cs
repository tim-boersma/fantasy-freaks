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
            int num = rnd.Next(0, 99);
            if (num >= 0 && 10 >= num)
            {
                return 0;
            }
            else if (num >= 11 && 32 >= num)
            {
                return 1;
            }
            else if (num >= 33 && 66 >= num)
            {
                return 2;
            }
            else if (num >= 67 && 88 >= num)
            {
                return 3;
            }
            else
                return 4;
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


        public static double CalculateOffensiveScore(IEnumerable<PlayerPerformanceDataModel> players) 
        {
            double totalScore = 0;
            foreach (var player in players)
            {
                var playerScore = (player.PassingTouchdowns * 5) + (player.RushingTouchdowns * 7) +
                (player.RecievingTouchdowns * 7) + (player.Receptions * 1) + (player.RushingYards * .125) +
                (player.RecievingYards * .125) + (player.PassingYards * .06) +
                (player.Interceptions * -3)
                + (player.Fumbles * -3); 
                totalScore += playerScore;
            }
            return totalScore;
        }

    }
}
