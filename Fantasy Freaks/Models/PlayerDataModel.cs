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
        public int ID { get; set; }
        [Column("Player_Name")]
        public string PlayerName { get; set; }
        [Column("Player_Position")]
        public string PlayerPosition { get; set; }
    }
}
