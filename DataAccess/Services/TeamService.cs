using DataAccess.Interfaces;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DataAccess.GlobalConstants;
using System.Windows.Forms;

namespace DataAccess.Services
{
    public class TeamService : ITeamService
    {
        private readonly FantasyDataContext _context;
        public TeamService(FantasyDataContext context)
        {
            _context = context;
        }

        public int CurrentWeek { get; set; } = 1;
        public WeekPerformance BestWeek { get; set; }
        public WeekPerformance WorstWeek { get; set; }
        public int TotalInjuries { get; set; } = 0;
        public int TotalBadDays { get; set; } = 0;
        public int TotalAveragePoints { get; set; } = 0;
        public int TotalGoodDays { get; set; } = 0;
        public int TotalMiraclePlays { get; set; } = 0;
        public CurrentPlayerModel Quarterback { get; set; }
        public CurrentPlayerModel WideReceiverOne { get; set; }
        public CurrentPlayerModel WideReceiverTwo { get; set; }
        public CurrentPlayerModel RunningBackOne { get; set; }
        public CurrentPlayerModel RunningBackTwo { get; set; }
        public CurrentPlayerModel TightEnd { get; set; }
        public CurrentPlayerModel Flex { get; set; }
        public List<CurrentPlayerModel> BenchedPlayers { get; set; } = new List<CurrentPlayerModel>();
        public List<DefenseDataModel> EnemyTeams { get; set; }
        public List<WeekPerformance> UserPerformance { get; set; } = new List<WeekPerformance>();

        public async Task WaitSomeTime(Button button, int time)
        {
            button.Enabled = false;
            await Task.Delay(time);
            button.Enabled = true;
        }

        public bool AllPlayersInitialized()
        {
            return Quarterback != null &&
                  WideReceiverOne != null &&
                  WideReceiverTwo != null &&
                  RunningBackOne != null &&
                  RunningBackTwo != null &&
                  TightEnd != null &&
                  Flex != null &&
                  BenchedPlayers.Count == 8;
        }

        public IEnumerable<int> GetActivePlayerIDs()
        {
            List<int> activePlayerIDs = new List<int>();
            if (Quarterback != null)
                activePlayerIDs.Add(Quarterback.PlayerID);
            if (WideReceiverOne != null)
                activePlayerIDs.Add(WideReceiverOne.PlayerID);
            if (WideReceiverTwo != null)
                activePlayerIDs.Add(WideReceiverTwo.PlayerID);
            if (RunningBackOne != null)
                activePlayerIDs.Add(RunningBackOne.PlayerID);
            if (RunningBackTwo != null)
                activePlayerIDs.Add(RunningBackTwo.PlayerID);
            if (TightEnd != null)
                activePlayerIDs.Add(TightEnd.PlayerID);
            if (Flex != null)
                activePlayerIDs.Add(Flex.PlayerID);

            return activePlayerIDs;
        }

        public IEnumerable<int> GetAllPlayerIDs()
        {
            List<int> activePlayerIDs = new List<int>();
            activePlayerIDs.AddRange(GetActivePlayerIDs());
            var benchedIDs = BenchedPlayers.Select(x => x.PlayerID);
            activePlayerIDs.AddRange(benchedIDs);
            return activePlayerIDs;
        }

        public async Task<List<PlayerPerformanceDataModel>> GetActivePlayerPerformances()
        {
            var playerIDs = GetActivePlayerIDs();
            var players = await GetPlayerPerformances(playerIDs, CurrentWeek);
            return players.ToList();
        }

        public async Task<List<CurrentPlayerModel>> GetActivePlayers()
        {
            var playerIDs = GetActivePlayerIDs();
            return await _context.CurrentPlayer.Where(x => playerIDs.Contains(x.PlayerID)).ToListAsync();
        }

        public async Task<PlayerPerformanceDataModel> GetPlayerPerformance(int playerID, int week)
        {
            var player = await _context.PlayerPerformance.Where(x => x.WeekPlayed == week && x.PlayerID == playerID).FirstOrDefaultAsync();
            if(player == null)
            {
                var noGametimePlayer = _context.CurrentPlayer.Where(x => x.PlayerID == playerID).FirstOrDefault();
                player = PlayerPerformanceDataModel.NoGametimePlayer(noGametimePlayer);
            }
            return player;
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

        public bool SetPosition(string position, CurrentPlayerModel player)
        {
            switch (position)
            {
                case PlayerTypes.Quarterback:
                    if (player.PlayerPosition == PlayerTypes.Quarterback)
                    {
                        Quarterback = player;
                        return true;
                    }
                    return false;
                case PlayerTypes.WideReceiverOne:
                    if (player.PlayerPosition == PlayerTypes.WideReceiver)
                    {
                        WideReceiverOne = player;
                        return true;
                    }
                    return false;
                case PlayerTypes.WideReceiverTwo:
                    if (player.PlayerPosition == PlayerTypes.WideReceiver)
                    {
                        WideReceiverTwo = player;
                        return true;
                    }
                    return false;
                case PlayerTypes.RunningBackOne:
                    if (player.PlayerPosition == PlayerTypes.RunningBack)
                    {
                        RunningBackOne = player;
                        return true;
                    }
                    return false;
                case PlayerTypes.RunningBackTwo:
                    if (player.PlayerPosition == PlayerTypes.RunningBack)
                    {
                        RunningBackTwo = player;
                        return true;
                    }
                    return false;
                case PlayerTypes.TightEnd:
                    if (player.PlayerPosition == PlayerTypes.TightEnd)
                    {
                        TightEnd = player;
                        return true;
                    }
                    return false;
                case PlayerTypes.Flex:
                    Flex = player;
                    return true;
                case PlayerTypes.Bench:
                    BenchedPlayers.Add(player);
                    return true;
                default:
                    return false;
            }
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

        private void ReplaceOnBench(CurrentPlayerModel activePlayer, CurrentPlayerModel benchedPlayer)
        {
            var index = BenchedPlayers.IndexOf(benchedPlayer);
            BenchedPlayers[index] = activePlayer;
        }

        public void SwapPlayers(CurrentPlayerModel activePlayer, CurrentPlayerModel benchedPlayer)
        {
            if (Quarterback.PlayerID == activePlayer.PlayerID)
            {
                ReplaceOnBench(Quarterback, benchedPlayer);
                Quarterback = benchedPlayer;
            }
            else if (WideReceiverOne.PlayerID == activePlayer.PlayerID)
            {
                ReplaceOnBench(WideReceiverOne, benchedPlayer);
                WideReceiverOne = benchedPlayer;
            }
            else if (WideReceiverTwo.PlayerID == activePlayer.PlayerID)
            {
                ReplaceOnBench(WideReceiverTwo, benchedPlayer);
                WideReceiverTwo = benchedPlayer;
            }
            else if (RunningBackOne.PlayerID == activePlayer.PlayerID)
            {
                ReplaceOnBench(RunningBackOne, benchedPlayer);
                RunningBackOne = benchedPlayer;
            }
            else if (RunningBackTwo.PlayerID == activePlayer.PlayerID)
            {
                ReplaceOnBench(RunningBackTwo, benchedPlayer);
                RunningBackTwo = benchedPlayer;
            }
            else if (TightEnd.PlayerID == activePlayer.PlayerID)
            {
                ReplaceOnBench(TightEnd, benchedPlayer);
                TightEnd = benchedPlayer;
            }
            else if (Flex.PlayerID == activePlayer.PlayerID)
            {
                ReplaceOnBench(Flex, benchedPlayer);
                Flex = benchedPlayer;
            }
        }
    }
}
