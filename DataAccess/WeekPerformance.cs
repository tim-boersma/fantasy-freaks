using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class WeekPerformance
    {
        public bool UserWon { get; set; }
        public double UserScore { get; set; }
        public double OppScore { get; set; }
        public WeekPerformance(double userScore, double oppScore)
        {
            UserScore = userScore;
            OppScore = oppScore;
            UserWon = userScore >= oppScore;

        }
    }

}
