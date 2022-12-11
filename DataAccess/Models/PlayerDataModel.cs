using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    public class CurrentPlayerModel
    {
        [Key]
        [Column("ID")]
        public int PlayerID { get; set; }
        [Column("Player_Name")]
        public string PlayerName { get; set; }
        [Column("Player_Position")]
        public string PlayerPosition { get; set; }
    }
}
