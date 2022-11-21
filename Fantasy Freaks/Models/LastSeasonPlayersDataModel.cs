using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Freaks.Models
{
    public class LastSeasonPlayerDataModel
    {
        [Key]
        [Column("ID")]
        public int PlayerID { get; set; }
        [Column("Team_Name")]
        public string TeamName { get; set; }
        [Column("Player_Pos")]
        public string PlayerPosition { get; set; }
        public double Age { get; set; }
        [Column("G")]
        public double Games { get; set; }
        [Column("GS")]
        public double GamesStarted { get; set; }
        [Column("Target")]
        public double PassTarget { get; set; }
        public double Receptions { get; set; }
        [Column("PassYds")]
        public double PassingYards { get; set; }
        [Column("PassTD")]
        public double PassingTouchdowns { get; set; }
        [Column("PassAtmpt")]
        public double PassAttempts { get; set; }
        [Column("RushYds")]
        public double RushingYards { get; set; }
        [Column("RushTD")]
        public double RushingTouchdowns { get; set; }
        [Column("RushAtmpt")]
        public double RushAttempts { get; set; }
        [Column("RecYds")]
        public double RecieivingYards { get; set; }
        [Column("RecTD")]
        public double RecievingTouchdowns { get; set; }
        [Column("Fantasy_Points")]
        public double FantasyPoints { get; set; }
        [Column("Interception")]
        public double Interceptions { get; set; }
        public double Fumbles { get; set; }
        public double FumblesLost { get; set; }
    }
}
