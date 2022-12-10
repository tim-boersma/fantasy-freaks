using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class GlobalConstants
    {
        public static class PlayerTypes
        {
            public const string Quarterback = "QB";
            public const string RunningBack = "RB";
            public const string RunningBackOne = "RB1";
            public const string RunningBackTwo = "RB2";
            public const string WideReceiver = "WR";
            public const string WideReceiverOne = "WR1";
            public const string WideReceiverTwo = "WR2";
            public const string TightEnd = "TE";
            public const string Flex = "FL";
            public const string Bench = "BE";
            public static readonly List<string> AllTypes = new List<string>() { 
                Quarterback,
                RunningBack,
                RunningBackTwo,
                WideReceiver, 
                WideReceiverTwo,
                TightEnd,
                Flex,
                Bench,
                WideReceiverOne,
                RunningBackOne
            };

            public static Dictionary<string, string> fullPlayerTypeNames = new Dictionary<string, string>()
            {
                {Quarterback, "Quarterback" },
                {RunningBack, "Running Back" },
                {RunningBackOne, "Running Back" },
                {RunningBackTwo, "Running Back" },
                {WideReceiver, "Wide Receiver" },
                {WideReceiverOne, "Wide Receiver" },
                {WideReceiverTwo, "Wide Receiver"  },
                {TightEnd, "Tight End"  },
                {Flex, "Flex Player" },
                {Bench, "Bench" },
            };
        }
    }
}
