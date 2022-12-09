using Fantasy_Freaks.Interfaces;
using Fantasy_Freaks.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Freaks
{
    public class TeamService : ITeamService
    {
        private readonly FantasyDataContext _context;
        private readonly FantasyDataContext _weekScore;
        public TeamService(FantasyDataContext context/*, weekScore*/)
        {
            _context = context;
        }
        /*public TeamService(FantasyDataContext weekScore)
        {
            _weekScore = weekScore;
        }*/

        public int CurrentWeek { get; set; } = 1;
        public int BestWeek { get; set; } = 0;
        public int WorstWeek { get; set; } = 0;
        public int TotalInjuries { get; set; } = 0;
        public int TotalBadDays { get; set; } = 0;
        public int TotalAveragePoints { get; set; } = 0;
        public int TotalGoodDays { get; set; } = 0;
        public int TotalMiraclePlays { get; set; } = 0;
        public int TotalPoints { get; set; } = 0;
        public CurrentPlayerModel Quarterback { get; set; }
        public CurrentPlayerModel WideReceiverOne { get; set; }
        public CurrentPlayerModel WideReceiverTwo { get; set; }
        public CurrentPlayerModel RunningBackOne { get; set; }
        public CurrentPlayerModel RunningBackTwo { get; set; }
        public CurrentPlayerModel TightEnd { get; set; }
        public CurrentPlayerModel Flex { get; set; }
        public List<CurrentPlayerModel> BenchedPlayers { get; set; }
        public List<DefenseDataModel> EnemyTeams { get; set; }

        
        public IEnumerable<int> GetActivePlayerIDs()
        {
            return new List<int>() {
                Quarterback.PlayerID,
                WideReceiverOne.PlayerID,
                WideReceiverTwo.PlayerID,
                RunningBackOne.PlayerID,
                RunningBackTwo.PlayerID,
                TightEnd.PlayerID
            };
        }

        public async Task<List<PlayerPerformanceDataModel>> GetActivePlayers()
        {
            var playerIDs = GetActivePlayerIDs();
            var players = await GetPlayerPerformances(playerIDs, CurrentWeek);
            return players.ToList();
        }

        public async Task<PlayerPerformanceDataModel> GetPlayerPerformance(int playerID, int week)
        {
            var data = GetPlayerWeek(week);
            return await data.Where(x => x.PlayerID == playerID).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<PlayerPerformanceDataModel>> GetPlayerPerformances(IEnumerable<int> playerIDs, int week)
        {
            List<PlayerPerformanceDataModel> players = new List<PlayerPerformanceDataModel>();
            foreach (var id in playerIDs)
            {
                players.Add(await GetPlayerPerformance(id, week));
            }
            return players;
        }

        public DbSet<PlayerPerformanceDataModel> GetPlayerWeek(int week)
        {
            switch (week)
            {
                case 1:
                    return _context.Week1Player;
                case 2:
                    return _context.Week2Player;
                case 3:
                    return _context.Week3Player;
                case 4:
                    return _context.Week4Player;
                case 5:
                    return _context.Week5Player;
                case 6:
                    return _context.Week6Player;
                case 7:
                    return _context.Week7Player;
                case 8:
                    return _context.Week8Player;
                case 9:
                    return _context.Week9Player;
                case 10:
                    return _context.Week10Player;
                case 11:
                    return _context.Week11Player;
                case 12:
                    return _context.Week12Player;
                case 13:
                    return _context.Week13Player;
                case 14:
                    return _context.Week14Player;
                case 15:
                    return _context.Week15Player;
                case 16:
                    return _context.Week16Player;
                case 17:
                    return _context.Week17Player;
                default:
                    return _context.Week1Player;
            }
        }


        public TeamService()
        {
            BenchedPlayers = new List<CurrentPlayerModel>();
            TotalPoints = 0;
        }

        public void NextWeek()
        {
            CurrentWeek++;
        }

        public DefenseDataModel GetCurrentOpponent()
        {
            if(EnemyTeams != null && EnemyTeams.Count >= CurrentWeek)
                return EnemyTeams[CurrentWeek - 1];
            return null;
        }
        public void SwapPlayers(CurrentPlayerModel activePlayer, CurrentPlayerModel benchedPlayer)
        {
            if (Quarterback.PlayerID == activePlayer.PlayerID)
            {
                BenchedPlayers.Remove(benchedPlayer);
                BenchedPlayers.Add(Quarterback);
                Quarterback = benchedPlayer;
            }
            else if (WideReceiverOne.PlayerID == activePlayer.PlayerID)
            {
                BenchedPlayers.Remove(benchedPlayer);
                BenchedPlayers.Add(WideReceiverOne);
                WideReceiverOne = benchedPlayer;
            }
            else if (WideReceiverTwo.PlayerID == activePlayer.PlayerID)
            {
                BenchedPlayers.Remove(benchedPlayer);
                BenchedPlayers.Add(WideReceiverTwo);
                WideReceiverTwo = benchedPlayer;
            }
            else if (RunningBackOne.PlayerID == activePlayer.PlayerID)
            {
                BenchedPlayers.Remove(benchedPlayer);
                BenchedPlayers.Add(RunningBackOne);
                RunningBackOne = benchedPlayer;
            }
            else if (RunningBackTwo.PlayerID == activePlayer.PlayerID)
            {
                BenchedPlayers.Remove(benchedPlayer);
                BenchedPlayers.Add(RunningBackTwo);
                RunningBackTwo = benchedPlayer;
            }
            else if (TightEnd.PlayerID == activePlayer.PlayerID)
            {
                BenchedPlayers.Remove(benchedPlayer);
                BenchedPlayers.Add(TightEnd);
                TightEnd = benchedPlayer;
            }
            else if (Flex.PlayerID == activePlayer.PlayerID)
            {
                BenchedPlayers.Remove(benchedPlayer);
                BenchedPlayers.Add(Flex);
                Flex = benchedPlayer;
            }
        }
    }
}
