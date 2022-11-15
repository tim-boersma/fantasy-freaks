using System.ComponentModel.DataAnnotations;

namespace Fantasy_Freaks
{
    public class ContributerDataModel
    {
        [Key]
        public int ContributerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
