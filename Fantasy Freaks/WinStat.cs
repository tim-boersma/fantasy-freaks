using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Freaks {
    internal class WinStat {
        public static WinStat instance;

        public WinStat() {
            instance = this;
        }

        public int Week { get; set; }
        public string OffName { get; set; }
        public int OffScore { get; set; }
        public int LowOffscore { get; set; }
        public int HighOffscore { get; set; }
        public string DefName { get; set; }
        public int DefScore { get; set; }

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

        public int CalculateDefensiveScore(int[] defense, int pointsAllowed, int yardsAllowed) {
            int defInt = 0, defFum = 0;

            return (defInt * 3) + (defFum * 2) + pointsAllowed + yardsAllowed;
        }


        public double CalculateOffensiveScore(int[] offense) {
            int passTD = 0, rushTD = 0, recTD = 0, rec = 0, rushYRDs = 0, recYRDs = 0, passYRDs = 0, offInt = 0, offFum = 0;

            return (passTD * 4) + (rushTD * 6) + (recTD * 6) + (rec * 1) + (rushYRDs * .1) + (recYRDs * .1) + (passYRDs * .04) + (offInt * -3) + (offFum * -3);
        }

    }
}
