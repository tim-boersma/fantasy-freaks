using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccess.Interfaces
{
    public interface ITeamService
    {
        int CurrentWeek { get; set; }
        WeekPerformance BestWeek { get; set; }
        WeekPerformance WorstWeek { get; set; }
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
        List<WeekPerformance> PlayerPerformance { get; set; }

        int TotalPoints { get; set; }
        void SwapPlayers(CurrentPlayerModel activePlayer, CurrentPlayerModel benchedPlayer);
        void NextWeek();
        Task WaitSomeTime(Button button, int time);
        DefenseDataModel GetCurrentOpponent();
        IEnumerable<int> GetActivePlayerIDs();
        IEnumerable<int> GetAllPlayerIDs();
        Task<List<CurrentPlayerModel>> GetActivePlayers();
        Task<List<PlayerPerformanceDataModel>> GetActivePlayerPerformances();
        bool SetPosition(string position, CurrentPlayerModel player);
        bool AllPlayersInitialized();
    }
}
