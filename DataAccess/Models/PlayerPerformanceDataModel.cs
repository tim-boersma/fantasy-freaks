using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    public class PlayerPerformanceDataModel
    {
        [Key]
        [Column("Player_Name")]
        public string PlayerName { get; set; }
        [Column("Player_Position")]
        public string PlayerPosition { get; set; }
        [Column("Team_Name")]
        public string TeamName { get; set; }
        [Column("Passing_Yards")]
        public double PassingYards { get; set; }
        [Column("Passing_Touchdowns")]
        public double PassingTouchdowns { get; set; }
        [Column("Interception")]
        public double Interceptions { get; set; }
        [Column("Pass_Attempts")]
        public double PassAttempts { get; set; }
        public double Completions { get; set; }
        [Column("Rushing_Attempts")]
        public double RushingAttempts { get; set; }
        [Column("Rushing_Yards")]
        public double RushingYards { get; set; }
        [Column("Rushing_Touchdowns")]
        public double RushingTouchdowns { get; set; }
        public double Receptions { get; set; }
        public double Target { get; set; }
        [Column("Receiving_Yards")]
        public double RecievingYards { get; set; }
        [Column("Receiving_Touchdowns")]
        public double RecievingTouchdowns { get; set; }
        [Column("ID")]
        public int PlayerID { get; set; }
        public double Fumbles { get; set; }
    }
}
