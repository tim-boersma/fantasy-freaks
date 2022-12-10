using DataAccess.Interfaces;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static DataAccess.GlobalConstants;

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

        public async Task<IEnumerable<CurrentPlayerModel>> GetSelectedPlayers(string playerSelection)
        {
            switch (playerSelection)
            {
                case PlayerTypes.Quarterback:
                    return await GetAllQuarterbacks();
                case PlayerTypes.RunningBack:
                    return await GetAllRunningbacks();
                case PlayerTypes.RunningBackOne:
                    return await GetAllRunningbacks();
                case PlayerTypes.RunningBackTwo:
                    return await GetAllRunningbacks();
                case PlayerTypes.TightEnd:
                    return await GetAllTightEnds();
                case PlayerTypes.WideReceiver:
                    return await GetAllWideReceivers();
                case PlayerTypes.WideReceiverOne:
                    return await GetAllWideReceivers();
                case PlayerTypes.WideReceiverTwo:
                    return await GetAllWideReceivers();
                default:
                    return await GetAllPlayers();
            }
        }

        public async Task<IEnumerable<CurrentPlayerModel>> GetAllQuarterbacks()
        {
            return await _context.CurrentPlayer.Where(x => x.PlayerPosition == "QB").ToListAsync();
        }

        public async Task<IEnumerable<CurrentPlayerModel>> GetAllRunningbacks()
        {
            List<CurrentPlayerModel> runningbacks = new List<CurrentPlayerModel>();
            runningbacks.AddRange(await _context.CurrentPlayer.Where(x => x.PlayerPosition == "RB").ToListAsync());
            runningbacks.AddRange(await _context.CurrentPlayer.Where(x => x.PlayerPosition == "HB").ToListAsync());
            runningbacks.AddRange(await _context.CurrentPlayer.Where(x => x.PlayerPosition == "FB").ToListAsync());
            return runningbacks;
        }

        public async Task<IEnumerable<CurrentPlayerModel>> GetAllWideReceivers()
        {
            return await _context.CurrentPlayer.Where(x => x.PlayerPosition == "WR").ToListAsync();
        }

        public async Task<IEnumerable<CurrentPlayerModel>> GetAllTightEnds()
        {
            return await _context.CurrentPlayer.Where(x => x.PlayerPosition == "TE").ToListAsync();
        }

        public async Task<IEnumerable<CurrentPlayerModel>> GetAllPlayers()
        {
            return await _context.CurrentPlayer.ToListAsync();
        }
    }
}
