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
        [Column("Player_Position")]
        public string PlayerPosition { get; set; }
        public double Age { get; set; }
        [Column("Games")]
        public double Games { get; set; }
        [Column("Games_Started")]
        public double GamesStarted { get; set; }
        [Column("Target")]
        public double PassTarget { get; set; }
        public double Receptions { get; set; }
        [Column("Passing_Yards")]
        public double PassingYards { get; set; }
        [Column("Passing_Touchdowns")]
        public double PassingTouchdowns { get; set; }
        [Column("Pass_Attempts")]
        public double PassAttempts { get; set; }
        [Column("Rushing_Yards")]
        public double RushingYards { get; set; }
        [Column("Rushing_Touchdowns")]
        public double RushingTouchdowns { get; set; }
        [Column("Rushing_Attempts")]
        public double RushAttempts { get; set; }
        [Column("Receiving_Yards")]
        public double RecieivingYards { get; set; }
        [Column("Receiving_Touchdowns")]
        public double RecievingTouchdowns { get; set; }
        [Column("Fantasy_Points")]
        public double FantasyPoints { get; set; }
        public double Interceptions { get; set; }
        public double Fumbles { get; set; }
        public double FumblesLost { get; set; }

        public bool IsPosition(string position) {
            IEnumerable<string> positions = PlayerPosition.Split('/');
            return positions.Where(x => x == position).Any();
        }
    }

}
