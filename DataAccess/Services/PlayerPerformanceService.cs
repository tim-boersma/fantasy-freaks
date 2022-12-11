using DataAccess.Interfaces;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DataAccess.GlobalConstants;

namespace DataAccess.Services
{
    public class PlayerPerformanceService : IPlayerPerformanceService
    {
        private readonly FantasyDataContext _context;
        public PlayerPerformanceService(FantasyDataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PlayerPerformanceDataModel>> AllPlayers(int week)
        {
            return await _context.PlayerPerformance.Where(x => x.WeekPlayed == week).ToListAsync();
        }

        public async Task<PlayerPerformanceDataModel> GetPlayerPerformance(int playerID, int week)
        {
            return await _context.PlayerPerformance.Where(x => x.WeekPlayed == week && x.PlayerID == playerID).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<PlayerPerformanceDataModel>> GetPlayerPerformances(IEnumerable<int> playerIDs, int week)
        {
            List<PlayerPerformanceDataModel> players = new List<PlayerPerformanceDataModel>();
            foreach(var id in playerIDs)
            {
                players.Add(await GetPlayerPerformance(id, week));
            }
            return players;
        }
    }
}
