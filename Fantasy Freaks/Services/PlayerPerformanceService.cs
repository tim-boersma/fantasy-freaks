using Fantasy_Freaks.Interfaces;
using Fantasy_Freaks.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Freaks.Services
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
            return await GetPlayerWeek(week).ToListAsync();
        }

        public async Task<PlayerPerformanceDataModel> GetPlayerPerformance(int playerID, int week)
        {
            var data = GetPlayerWeek(week);
            return await data.Where(x => x.PlayerID == playerID).FirstOrDefaultAsync();
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

        public DbSet<PlayerPerformanceDataModel> GetPlayerWeek(int week)
        {
            switch (week)
            {
                case 1:
                    return _context.Week1Player;
                case 2:
                    return _context.Week2Player;
                case 3:
                    return _context.Week3Player;
                case 4:
                    return _context.Week4Player;
                case 5:
                    return _context.Week5Player;
                case 6:
                    return _context.Week6Player;
                case 7:
                    return _context.Week7Player;
                case 8:
                    return _context.Week8Player;
                case 9:
                    return _context.Week9Player;
                case 10:
                    return _context.Week10Player;
                case 11:
                    return _context.Week11Player;
                case 12:
                    return _context.Week12Player;
                case 13:
                    return _context.Week13Player;
                case 14:
                    return _context.Week14Player;
                case 15:
                    return _context.Week15Player;
                case 16:
                    return _context.Week16Player;
                case 17:
                    return _context.Week17Player;
                default:
                    return _context.Week1Player;
            }

        }
    }
}
