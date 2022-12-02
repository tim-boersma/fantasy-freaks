using Fantasy_Freaks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Freaks
{
    public class Game
    {
        public int CurrentWeek { get; set; }
        public List<CurrentPlayerModel> ActivePlayers { get; set; }
        public List<CurrentPlayerModel> BenchedPlayers { get; set; }

        public List<DefenseDataModel> EnemyTeams { get; set; }

        //speculation
        public int TotalPoints { get; set; }

        public Game()
        {
            ActivePlayers = new List<CurrentPlayerModel>();
            BenchedPlayers = new List<CurrentPlayerModel>();
            CurrentWeek = 1;
            TotalPoints = 0;
        }
    }
}
