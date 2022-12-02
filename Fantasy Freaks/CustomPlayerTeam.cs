using Fantasy_Freaks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Freaks
{
    public class CustomPlayerTeam
    {
        public int CurrentWeek { get; set; }
        public List<PlayerDataModel> ActivePlayers { get; set; }
        public List<PlayerDataModel> BenchedPlayers { get; set; }

        //speculation
        public int TotalPoints { get; set; }

        public CustomPlayerTeam()
        {
            ActivePlayers = new List<PlayerDataModel>();
            BenchedPlayers = new List<PlayerDataModel>();
            CurrentWeek = 1;
            TotalPoints = 0;
        }
    }
}
