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
        public int PointsAllowed { get; set; }
        [Column("TotYdsAllow")]
        public int TotalYardsAllowed { get; set; }
        [Column("OffPlayAllow")]
        public int OffPlaysAllowed { get; set; }
        [Column("YdsPerPlay")]
        public int YardsPerPlay { get; set; }
        [Column("Turnovers")]
        public int Turnovers { get; set; }
        [Column("ForceFumb")]
        public int ForcedFumbles { get; set; }
        [Column("TotFirstDownAllow")]
        public int TotalFirstDownsAllowed { get; set; }
        public int Completions { get; set; }
        [Column("PassAtmptAllow")]
        public int PassAttemptsAllowed { get; set; }
        [Column("PassYdsAllow")]
        public int PassingYardsAllowed { get; set; }
        [Column("PassTDAllow")]
        public int PassingTouchdownsAllowed { get; set; }
        public int Interceptions { get; set; }
        [Column("NetYdsAllowPerPass")]
        public int NetYardsAllowedPerPass { get; set; }
        [Column("PassFirstDownAllow")]
        public int FirstDownPassesAllowed { get; set; }
        [Column("RushAtmptAllow")]
        public int RushintAttemptsAllowed { get; set; }
        [Column("RushYdsAllow")]
        public int RushingYardsAllowed { get; set; }
        [Column("RushTDAllow")]
        public int RushingTouchdownsAllowed { get; set; }
        [Column("YdsPerRushAllow")]
        public int YardsPerRushAllowed { get; set; }
        [Column("RushFirstDownAllow")]
        public int RushingFirstDownsAllowed { get; set; }
        [Column("PenCommited")]
        public int PenaltiesCommitted { get; set; }
        [Column("PenYdsAllow")]
        public int PenaltyYardsAllowed { get; set; }
        [Column("FirstDownViaPen")]
        public int FirstDownsViaPenalties { get; set; }
        [Column("PercDrivesEndOffScore")]
        public int PercDrivesEndOffScore { get; set; }
        [Column("PercDrivesEndTO")]
        public int PercDrivesEndTO { get; set; }
    }
}
