using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Freaks.Models
{
    public class PlayerDataModel
    {
        [Column("Player_Name")]
        public string PlayerName { get; set; }
        [Column("Player_Pos")]
        public string PlayerPosition { get; set; }
        [Column("Team_Name")]
        public string TeamName { get; set; }
        [Column("PassYds")]
        public int PassingYards { get; set; }
        [Column("PassTD")]
        public int PassTD { get; set; }
        public int Interceptions { get; set; }
        [Column("PassAtmpt")]
        public int PassAttempts { get; set; }
        [Column("Completions")]
        public int Completions { get; set; }
        [Column("RushAtmpt")]
        public int RushAttempts { get; set; }
        [Column("RushYds")]
        public int RushingYards { get; set; }
        [Column("RushTD")]
        public int RushingTouchdowns { get; set; }
        public int Receptions { get; set; }
        public int Target { get; set; }
        [Column("RecYds")]
        public int RecievingYards { get; set; }
        [Column("RecTD")]
        public int RecievingTouchdowns { get; set; }
        [Column("ID")]
        public int ID { get; set; } 
    }
}
