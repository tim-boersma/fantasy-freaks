using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface ITeamService
    {
        int CurrentWeek { get; set; }
        int BestWeek { get; set; }
        int WorstWeek { get; set; }
        int TotalInjuries { get; set; }
        int TotalBadDays { get; set; }
        int TotalAveragePoints { get; set; }
        int TotalGoodDays { get; set; }
        int TotalMiraclePlays { get; set; }
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
        void NextWeek();
        DefenseDataModel GetOpponents();

        Task<List<PlayerPerformanceDataModel>> GetActivePlayers();
        bool SetPosition(string position, CurrentPlayerModel player);
        bool AllPlayersInitialized();
    }
}
