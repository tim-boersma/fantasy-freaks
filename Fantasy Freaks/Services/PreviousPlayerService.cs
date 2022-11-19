using Fantasy_Freaks.Models;
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
    }
}
