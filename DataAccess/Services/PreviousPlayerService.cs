using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAccess.Services
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

        private Expression<Func<LastSeasonPlayerDataModel, bool>> IsPosition(string position)
        {
            string delimiter = "/";
            return (LastSeasonPlayerDataModel x) => x.PlayerPosition == position || x.PlayerPosition.StartsWith(position + delimiter) ||
            x.PlayerPosition.EndsWith(delimiter + position) || x.PlayerPosition.Contains(delimiter + position + delimiter);
        }

        public async Task<IEnumerable<LastSeasonPlayerDataModel>> GetAllQuarterbacks() 
        {
            return await _context.LastSeasonPlayer.Where(IsPosition("QB")).ToListAsync();
        }


        public async Task<IEnumerable<LastSeasonPlayerDataModel>> GetAllRunningbacks() 
        {
            List<LastSeasonPlayerDataModel> runningbacks = new List<LastSeasonPlayerDataModel>();
            runningbacks.AddRange(await _context.LastSeasonPlayer.Where(IsPosition("RB")).ToListAsync());
            runningbacks.AddRange(await _context.LastSeasonPlayer.Where(IsPosition("HB")).ToListAsync());
            runningbacks.AddRange(await _context.LastSeasonPlayer.Where(IsPosition("FB")).ToListAsync());
            return runningbacks;
        }

        public async Task<IEnumerable<LastSeasonPlayerDataModel>> GetAllWideReceivers()
        {
            return await _context.LastSeasonPlayer.Where(IsPosition("WR")).ToListAsync();
        }

        public async Task<IEnumerable<LastSeasonPlayerDataModel>> GetAllTightEnds()
        {
            return await _context.LastSeasonPlayer.Where(IsPosition("TE")).ToListAsync();
        }

        public async Task<IEnumerable<LastSeasonPlayerDataModel>> GetAllPlayers()
        {
            return await _context.LastSeasonPlayer.ToListAsync();
        }
    }
}
