using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public interface IDefenseService
    {
        Task<IEnumerable<DefenseDataModel>> AllTeams();
        Task<IEnumerable<DefenseDataModel>> RandomTeams(int amount);
    }
}
