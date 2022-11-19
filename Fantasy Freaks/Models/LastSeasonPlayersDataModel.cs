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
        public int Age { get; set; }
        [Column("G")]
        public int Games { get; set; }
        [Column("GS")]
        public int GamesStarted { get; set; }
        [Column("Target")]
        public int PassTarget { get; set; }
        public int Receptions { get; set; }
        [Column("PassYds")]
        public int PassingYards { get; set; }
        [Column("PassTD")]
        public int PassingTouchdowns { get; set; }
        [Column("PassAtmpt")]
        public int PassAttempts { get; set; }
        [Column("RushYds")]
        public int RushingYards { get; set; }
        [Column("RushTD")]
        public int RushingTouchdowns { get; set; }
        [Column("RushAtmpt")]
        public int RushAttempts { get; set; }
        [Column("RecYds")]
        public int RecieivingYards { get; set; }
        [Column("RecTD")]
        public int RecievingTouchdowns { get; set; }
        [Column("Fantasy_Points")]
        public int FantasyPoints { get; set; }
        public int Interceptions { get; set; }
        public int Fumbles { get; set; }
        public int FumbleLost { get; set; }
    }
}
