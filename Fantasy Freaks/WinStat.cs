using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Freaks
{
    class WinStat
    {
        //teams are in order for the defense databse - 0 = NEP / 31 MD
        //don't recommend we do it this way instead should use our data repository and take data from there - unsure how to do
        public static int[] Defense = new int[32];

        public string offName { get; set; }
        public int offScore { get; set; }
        public int lowOffscore { get; set; }
        public int highOffscore { get; set; }

        public string defName { get; set; }
        public int defScore { get; set; }

        public int eventDay()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 5);
            return num;
        }

        public int Tpscore(int tp)
        {
            int lty = tp - 201;//lowest score
            int score = 0;
            for (int i = 0; i < 20; i++)
            {
                lty = lty - 20;//iteration = gap
                if (lty >= 0)
                    score++;
            }
            return 48 - 2 * score;
        }


        public static int TYscore(int ty)
        {
            int lty = ty - 4301;//lowest score
            int score = 0;
            for (int i = 0; i < 20; i++)
            {
                lty = lty - 150;//iteration = gap
                if (lty >= 0)
                    score++;
            }
            return 46 - 2 * score;
        }

        public int defScoreCalc(int[] defense, int pointsAllowed, int yardsAllowed)
        {
            int defInt = 0, defFum = 0;

            return (defInt * 3) + (defFum * 2) + pointsAllowed + yardsAllowed;
        }


        public double offScoreCalc(int[] offense)
        {
            int passTD = 0, rushTD = 0, recTD = 0, rec = 0, rushYRDs = 0, recYRDs = 0, passYRDs = 0, offInt = 0, offFum = 0;

            return (passTD * 4) + (rushTD * 6) + (recTD * 6) + (rec * 1) + (rushYRDs * .1) + (recYRDs * .1) + (passYRDs * .04) + (offInt * -3) + (offFum * -3);
        }

    }

}
