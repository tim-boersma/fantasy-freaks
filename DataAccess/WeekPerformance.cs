using DataAccess.Models;
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
        public double UserScore { get; set; } = 0;
        public double OppScore { get; set; } = 0;
        public DefenseDataModel OpposingTeam { get; set; }
        public WeekPerformance(double userScore, double oppScore, DefenseDataModel enemy)
        {
            UserScore = userScore;
            OppScore = oppScore;
            UserWon = userScore >= oppScore;
            OpposingTeam = enemy;
        }
    }

}
