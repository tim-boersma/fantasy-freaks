using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public interface IPreviousPlayerService
    {
        Task<IEnumerable<LastSeasonPlayerDataModel>> GetAllPlayers();
        Task<IEnumerable<LastSeasonPlayerDataModel>> GetAllQuarterbacks();
        Task<IEnumerable<LastSeasonPlayerDataModel>> GetAllRunningbacks();
        Task<IEnumerable<LastSeasonPlayerDataModel>> GetAllWideReceivers();
        Task<IEnumerable<LastSeasonPlayerDataModel>> GetAllTightEnds();
    }
}
