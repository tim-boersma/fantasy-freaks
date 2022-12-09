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
        [Column("Passed_Ball")]
        public double PassedBall { get; set; }
        [Column("Receiving_Yards")]
        public double RecievingYards { get; set; }
        [Column("Receiving_Touchdowns")]
        public double RecievingTouchdowns { get; set; }
        [Column("ID")]
        public int PlayerID { get; set; }
        public double Fumbles { get; set; }
        public int WeekPlayed { get; set; }

        public static PlayerPerformanceDataModel NoGametimePlayer(CurrentPlayerModel player)
        {
            return new PlayerPerformanceDataModel()
            {
                PlayerName = player.PlayerName,
                PlayerPosition = player.PlayerPosition,
                TeamName = "",
                PassingYards = 0,
                PassingTouchdowns = 0,
                Interceptions = 0,
                PassAttempts = 0,
                Completions = 0,
                RushingAttempts = 0,
                RushingYards = 0,
                RushingTouchdowns = 0,
                Receptions = 0,
                PassedBall = 0,
                RecievingYards = 0,
                RecievingTouchdowns = 0,
                PlayerID = player.PlayerID,
                Fumbles = 0
            };
        }
    }

}
