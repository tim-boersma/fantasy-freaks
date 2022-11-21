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



        public async Task<IEnumerable<LastSeasonPlayerDataModel>> AllPlayers()
        {
            var retValue = await _context.LastSeasonPlayer.ToListAsync();
            var assignment = 0;
            StupidDebug(assignment);
            return retValue;
        }
        public static int StupidDebug(int sf)
        {
            return sf * 2;
        }
    }
}
