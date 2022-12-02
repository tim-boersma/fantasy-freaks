using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Freaks
{
    public class GameResult
    {
        public GameResult()
        {
            Week = 0;
            OffName = "";
            OffScore = 0;
            LowOffscore = 0;
            HighOffscore = 0;
            DefName = "";
            DefScore = 0;
        }

        public int Week { get; set; }
        public string OffName { get; set; }
        public int OffScore { get; set; }
        public int LowOffscore { get; set; }
        public int HighOffscore { get; set; }
        public string DefName { get; set; }
        public int DefScore { get; set; }
    }
}
