using DataAccess.Interfaces;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services
{
    public class CurrentPlayerService : ICurrentPlayerService
    {
        private readonly FantasyDataContext _context;
        public CurrentPlayerService(FantasyDataContext context)
        {
            _context = context;
        }

        public async Task<CurrentPlayerModel> GetPlayer(int playerID)
        {
            return await _context.CurrentPlayer.Where(x => x.PlayerID == playerID).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<CurrentPlayerModel>> GetPlayers(IEnumerable<int> playerIDs)
        {
            List<CurrentPlayerModel> players = new List<CurrentPlayerModel>();
            foreach (var id in playerIDs)
            {
                players.Add(await GetPlayer(id));
            }
            return players;
        }

        private Expression<Func<CurrentPlayerModel, bool>> IsPosition(string position)
        {
            string delimiter = "/";
            return (CurrentPlayerModel x) => x.PlayerPosition == position || x.PlayerPosition.StartsWith(position + delimiter) ||
            x.PlayerPosition.EndsWith(delimiter + position) || x.PlayerPosition.Contains(delimiter + position + delimiter);
        }

        public async Task<IEnumerable<CurrentPlayerModel>> GetAllQuarterbacks()
        {
            return await _context.CurrentPlayer.Where(IsPosition("QB")).ToListAsync();
        }


        public async Task<IEnumerable<CurrentPlayerModel>> GetAllRunningbacks()
        {
            List<CurrentPlayerModel> runningbacks = new List<CurrentPlayerModel>();
            runningbacks.AddRange(await _context.CurrentPlayer.Where(IsPosition("RB")).ToListAsync());
            runningbacks.AddRange(await _context.CurrentPlayer.Where(IsPosition("HB")).ToListAsync());
            runningbacks.AddRange(await _context.CurrentPlayer.Where(IsPosition("FB")).ToListAsync());
            return runningbacks;
        }

        public async Task<IEnumerable<CurrentPlayerModel>> GetAllWideReceivers()
        {
            return await _context.CurrentPlayer.Where(IsPosition("WR")).ToListAsync();
        }

        public async Task<IEnumerable<CurrentPlayerModel>> GetAllTightEnds()
        {
            return await _context.CurrentPlayer.Where(IsPosition("TE")).ToListAsync();
        }

        public async Task<IEnumerable<CurrentPlayerModel>> GetAllPlayers()
        {
            return await _context.CurrentPlayer.ToListAsync();
        }
    }
}
