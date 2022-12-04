using Fantasy_Freaks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Freaks.Interfaces
{
    public interface ITeamService
    {
        int CurrentWeek { get; set; }
        CurrentPlayerModel Quarterback { get; set; }
        CurrentPlayerModel WideReceiverOne { get; set; }
        CurrentPlayerModel WideReceiverTwo { get; set; }
        CurrentPlayerModel RunningBackOne { get; set; }
        CurrentPlayerModel RunningBackTwo { get; set; }
        CurrentPlayerModel TightEnd { get; set; }
        CurrentPlayerModel Flex { get; set; }

        List<CurrentPlayerModel> BenchedPlayers { get; set; }

        List<DefenseDataModel> EnemyTeams { get; set; }

        //speculation
        int TotalPoints { get; set; }
        void SwapPlayers(CurrentPlayerModel activePlayer, CurrentPlayerModel benchedPlayer);
    }
}
