using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Freaks.Models
{
    public class PlayerDataModel
    {
        [Key]
        [Column("Player_Name")]
        public string PlayerName { get; set; }
        [Column("Player_Pos")]
        public string PlayerPosition { get; set; }
        [Column("Team_Name")]
        public string TeamName { get; set; }
        [Column("PassYds")]
        public double PassingYards { get; set; }
        [Column("PassTD")]
        public double PassTD { get; set; }
        [Column("Interception")]
        public double Interceptions { get; set; }
        [Column("PassAtmpt")]
        public double PassAttempts { get; set; }
        [Column("Completions")]
        public double Completions { get; set; }
        [Column("RushAtmpt")]
        public double RushAttempts { get; set; }
        [Column("RushYds")]
        public double RushingYards { get; set; }
        [Column("RushTD")]
        public double RushingTouchdowns { get; set; }
        public double Receptions { get; set; }
        public double Target { get; set; }
        [Column("RecYds")]
        public double RecievingYards { get; set; }
        [Column("RecTD")]
        public double RecievingTouchdowns { get; set; }
        //[Column("ID")]
        //public double? ID { get; set; } 
    }
}
