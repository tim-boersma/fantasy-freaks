
using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface ICurrentPlayerService
    {
        Task<CurrentPlayerModel> GetPlayer(int playerID);
        Task<IEnumerable<CurrentPlayerModel>> GetPlayers(IEnumerable<int> playerIDs);
        Task<IEnumerable<CurrentPlayerModel>> GetAllQuarterbacks();
        Task<IEnumerable<CurrentPlayerModel>> GetSelectedPlayers(string playerSelection);
        Task<IEnumerable<CurrentPlayerModel>> GetAllRunningbacks();
        Task<IEnumerable<CurrentPlayerModel>> GetAllWideReceivers();
        Task<IEnumerable<CurrentPlayerModel>> GetAllTightEnds();
        Task<IEnumerable<CurrentPlayerModel>> GetAllPlayers();
    }
}
