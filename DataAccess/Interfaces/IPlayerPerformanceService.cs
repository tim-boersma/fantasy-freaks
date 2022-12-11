using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IPlayerPerformanceService
    {
        Task<IEnumerable<PlayerPerformanceDataModel>> AllPlayers(int week);
        Task<IEnumerable<PlayerPerformanceDataModel>> GetPlayerPerformances(IEnumerable<int> playerIDs, int week);
        Task<PlayerPerformanceDataModel> GetPlayerPerformance(int playerID, int week);
    }
}
