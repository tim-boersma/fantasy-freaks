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
        [Column("Team_Name")]
        public string TeamName { get; set; }
        [Column("PtsAllow")]
        public double PointsAllowed { get; set; }
        [Column("TotYdsAllow")]
        public double TotalYardsAllowed { get; set; }
        [Column("OffPlayAllow")]
        public double OffPlaysAllowed { get; set; }
        [Column("YdsPerPlay")]
        public double YardsPerPlay { get; set; }
        [Column("Turnovers")]
        public double Turnovers { get; set; }
        [Column("ForceFumb")]
        public double ForcedFumbles { get; set; }
        [Column("TotFirstDownAllow")]
        public double TotalFirstDownsAllowed { get; set; }
        public double Completions { get; set; }
        [Column("PassAtmptAllow")]
        public double PassAttemptsAllowed { get; set; }
        [Column("PassYdsAllow")]
        public double PassingYardsAllowed { get; set; }
        [Column("PassTDAllow")]
        public double PassingTouchdownsAllowed { get; set; }
        public double Interceptions { get; set; }
        [Column("NetYdsAllowPerPass")]
        public double NetYardsAllowedPerPass { get; set; }
        [Column("PassFirstDownAllow")]
        public double FirstDownPassesAllowed { get; set; }
        [Column("RushAtmptAllow")]
        public double RushintAttemptsAllowed { get; set; }
        [Column("RushYdsAllow")]
        public double RushingYardsAllowed { get; set; }
        [Column("RushTDAllow")]
        public double RushingTouchdownsAllowed { get; set; }
        [Column("YdsPerRushAllow")]
        public double YardsPerRushAllowed { get; set; }
        [Column("RushFirstDownAllow")]
        public double RushingFirstDownsAllowed { get; set; }
        [Column("PenCommited")]
        public double PenaltiesCommitted { get; set; }
        [Column("PenYdsAllow")]
        public double PenaltyYardsAllowed { get; set; }
        [Column("FirstDownViaPen")]
        public double FirstDownsViaPenalties { get; set; }
        [Column("PercDrivesEndOffScore")]
        public double PercDrivesEndOffScore { get; set; }
        [Column("PercDrivesEndTO")]
        public double PercDrivesEndTO { get; set; }
    }
}
