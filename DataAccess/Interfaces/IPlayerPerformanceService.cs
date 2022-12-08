using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IPlayerPerformanceService
    {
        Task<IEnumerable<PlayerPerformanceDataModel>> AllPlayers(int week);
    }
}
