using Fantasy_Freaks.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Freaks.Services
{
    public class DefenseService : IDefenseService
    {
        private readonly FantasyDataContext _context;
        public DefenseService(FantasyDataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DefenseDataModel>> AllTeams()
        {
            var test = await _context.Defense.ToListAsync();
            var assignment = 0;
            StupidDebug(assignment);
            return test;
        }

        public static int StupidDebug(int sf)
        {
            return sf * 2;
        }
    }
}
