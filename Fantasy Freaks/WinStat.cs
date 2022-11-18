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

        public int CalculateDefensiveScore(DefensiveTeam defTeam, int pointsAllowed, int yardsAllowed) 
        {
            return (defTeam.defInt * 3) + (defTeam.defFum * 2) + pointsAllowed + yardsAllowed;
        }


        public double CalculateOffensiveScore(Player player) 
        {
            return (player.passTD * 4) + (player.rushTD * 6) + (player.recTD * 6) + (player.rec * 1) + (player.rushYRDs * .1) + (player.recYRDs * .1) + (player.passYRDs * .04) + (player.offInt * -3) + (player.offFum * -3);
        }

    }
}
