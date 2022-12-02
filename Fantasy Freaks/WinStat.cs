using Fantasy_Freaks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Freaks {
    public class WinStat {

        public int EventForDay() {
            Random rnd = new Random();
            int num = rnd.Next(0, 5);
            return num;
        }

        public int CalculateScoreFromTotalPoints(int PointsAllowed) {
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

        public int CalculateDefensiveScore(DefenseDataModel defTeam, int pointsAllowed, int yardsAllowed) 
        {
            return (int)((defTeam.Interceptions * 3) + (defTeam.ForcedFumbles * 2) + defTeam.PointsAllowed + defTeam.TotalYardsAllowed);
        }


        public double CalculateOffensiveScore(PlayerPerformanceDataModel player) 
        {
            return (player.PassingYards * 4) + (player.RushingTouchdowns * 6) +
                (player.RecievingTouchdowns * 6) + (player.Receptions * 1) + (player.RushingYards * .1) +
                (player.RecievingYards * .1) + (player.PassingYards * .04) +
                (player.Interceptions * -3); 
                //There are currently no Fumble stats for players, but when it is implemented this is what it'll look like
                //+ (player.Fumbles * -3);
        }

    }
}
