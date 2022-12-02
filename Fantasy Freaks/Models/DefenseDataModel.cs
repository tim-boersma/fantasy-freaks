using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Freaks.Models
{
    public class DefenseDataModel
    {
        public int ID { get; set; }
        public string TeamName { get; set; }
        public double PointsAllowed { get; set; }
        public double TotalYardsAllowed { get; set; }
        public double OffensePlaysAllowed { get; set; }
        public double YardsPerPlay { get; set; }
        public double Turnovers { get; set; }
        public double ForcedFumbles { get; set; }
        public double TotalFirstDownsAllowed { get; set; }
        public double Completions { get; set; }
        public double PassingAttemptsAllowed { get; set; }
        public double PassingYardsAllowed { get; set; }
        public double PassingTouchdownsAllowed { get; set; }
        public double Interceptions { get; set; }
        public double NetYardsAllowedPerPass { get; set; }
        public double PassingFirstDownsAllowed { get; set; }
        public double RushingAttemptsAllowed { get; set; }
        public double RushingYardsAllowed { get; set; }
        public double RushingTouchdownsAllowed { get; set; }
        public double YardsPerRushAllowed { get; set; }
        public double RushingFirstDownsAllowed { get; set; }
        public double PenaltiesCommitted { get; set; }
        public double PenaltyYardsAllowed { get; set; }
        public double FirstDownsViaPenalties { get; set; }
        public double PercentDrivesEndOffScore { get; set; }
        public double PercentDrivesEndTurnover { get; set; }
    }
}
