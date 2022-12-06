using Fantasy_Freaks.Interfaces;
using Fantasy_Freaks.Models;
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
        public int CurrentWeek { get; set; }
        public CurrentPlayerModel Quarterback { get; set; }
        public CurrentPlayerModel WideReceiverOne { get; set; }
        public CurrentPlayerModel WideReceiverTwo { get; set; }
        public CurrentPlayerModel RunningBackOne { get; set; }
        public CurrentPlayerModel RunningBackTwo { get; set; }
        public CurrentPlayerModel TightEnd { get; set; }
        public CurrentPlayerModel Flex { get; set; }
        public List<CurrentPlayerModel> BenchedPlayers { get; set; }
        public List<DefenseDataModel> EnemyTeams { get; set; }

        //speculation
        public int TotalPoints { get; set; }
        public int TotalInjuries { get; set; }
        public int TotalBadDays { get; set; }
        public int AveragePoints { get; set; }
        public int TotalGoodDays { get; set; }
        public int TotalMiraclePlays { get; set; }


        public TeamService()
        {
            BenchedPlayers = new List<CurrentPlayerModel>();
            CurrentWeek = 1;
            TotalPoints = 0;
        }

        public void NextWeek()
        {
            CurrentWeek++;
        }

        public void SwapPlayers(CurrentPlayerModel activePlayer, CurrentPlayerModel benchedPlayer)
        {
            if(Quarterback.PlayerID == activePlayer.PlayerID)
            {
                BenchedPlayers.Remove(benchedPlayer);
                BenchedPlayers.Add(Quarterback);
                Quarterback = benchedPlayer;
            }
            else if(WideReceiverOne.PlayerID == activePlayer.PlayerID)
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
