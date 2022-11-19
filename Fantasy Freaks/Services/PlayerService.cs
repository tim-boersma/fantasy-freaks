using Fantasy_Freaks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Freaks.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly FantasyDataContext _context;
        public PlayerService(FantasyDataContext context)
        {
            _context = context;
        }
    }
}
