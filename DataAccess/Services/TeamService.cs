﻿using DataAccess.Interfaces;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
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
        public double BestWeek { get; set; } = 0;
        public double WorstWeek { get; set; } = 0;
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
        public List<CurrentPlayerModel> BenchedPlayers { get; set; } = new List<CurrentPlayerModel>();
        public List<DefenseDataModel> EnemyTeams { get; set; }
        public List<WeekPerformance> PlayerPerformance { get; set; } = new List<WeekPerformance>();

        public async Task WaitSomeTime(Button button)
        {
            button.Enabled = false;
            await Task.Delay(1000);
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
            return new List<int>() {
                Quarterback.PlayerID,
                WideReceiverOne.PlayerID,
                WideReceiverTwo.PlayerID,
                RunningBackOne.PlayerID,
                RunningBackTwo.PlayerID,
                TightEnd.PlayerID,
                Flex.PlayerID
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
            var player = await data.Where(x => x.PlayerID == playerID).FirstOrDefaultAsync();
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
                case PlayerTypes.WideReceiver:
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
                case PlayerTypes.RunningBack:
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
