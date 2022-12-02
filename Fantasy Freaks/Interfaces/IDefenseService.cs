using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Freaks.Models
{
    public interface IDefenseService
    {
        Task<IEnumerable<DefenseDataModel>> AllTeams();
        Task<IEnumerable<DefenseDataModel>> RandomTeams(int amount);
    }
}
