using Fantasy_Freaks.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Freaks.Services
{
    public class PreviousPlayerService : IPreviousPlayerService
    {
        private readonly FantasyDataContext _context;
        public PreviousPlayerService(FantasyDataContext context)
        {
            _context = context;
        }

        public async Task<LastSeasonPlayerDataModel> GetPlayer(int playerID)
        {
            return await _context.LastSeasonPlayer.Where(x => x.PlayerID == playerID).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<LastSeasonPlayerDataModel>> GetPlayers(IEnumerable<int> playerIDs)
        {
            List<LastSeasonPlayerDataModel> players = new List<LastSeasonPlayerDataModel>();
            foreach(var id in playerIDs)
            {
                players.Add(await GetPlayer(id));
            }
            return players;
        }

        public async Task<IEnumerable<LastSeasonPlayerDataModel>> GetAllQuarterBacks() 
        {
            return await _context.LastSeasonPlayer.Where(x => x.IsPosition("QB")).ToListAsync();
        }

        public async Task<IEnumerable<LastSeasonPlayerDataModel>> GetAllRunningBacks() 
        {
            return await _context.LastSeasonPlayer.Where(x => x.IsPosition("RB")).ToListAsync();
        }

        public async Task<IEnumerable<LastSeasonPlayerDataModel>> GetAllFullBacks() 
        {
            return await _context.LastSeasonPlayer.Where(x => x.IsPosition("FB")).ToListAsync();
        }

        public async Task<IEnumerable<LastSeasonPlayerDataModel>> GetAllHalfBacks() 
        {
            return await _context.LastSeasonPlayer.Where(x => x.IsPosition("HB")).ToListAsync();
        }

        public async Task<IEnumerable<LastSeasonPlayerDataModel>> GetAllOffensiveLinemen() 
        {
            return await _context.LastSeasonPlayer.Where(x => x.IsPosition("OL")).ToListAsync();
        }

        public async Task<IEnumerable<LastSeasonPlayerDataModel>> GetAllGuards() 
        {
            return await _context.LastSeasonPlayer.Where(x => x.IsPosition("G")).ToListAsync();
        }

        public async Task<IEnumerable<LastSeasonPlayerDataModel>> GetAllTackles() 
        {
            return await _context.LastSeasonPlayer.Where(x => x.IsPosition("T")).ToListAsync();
        }

        public async Task<IEnumerable<LastSeasonPlayerDataModel>> GetAllCenters() 
        {
            return await _context.LastSeasonPlayer.Where(x => x.IsPosition("C")).ToListAsync();
        }

        public async Task<IEnumerable<LastSeasonPlayerDataModel>> GetAllWideReceivers() 
        {
            return await _context.LastSeasonPlayer.Where(x => x.IsPosition("WR")).ToListAsync();
        }

        public async Task<IEnumerable<LastSeasonPlayerDataModel>> GetAllTightEnds() 
        {
            return await _context.LastSeasonPlayer.Where(x => x.IsPosition("TE")).ToListAsync();
        }

        public async Task<IEnumerable<LastSeasonPlayerDataModel>> GetAllPlayers()
        {
            return await _context.LastSeasonPlayer.ToListAsync();
        }
    }
}
