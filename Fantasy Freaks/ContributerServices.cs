using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Freaks
{
    public class ContributerServices : IContributerServices
    {
        private readonly ContributerDataContext _context;
        ContributerServices(ContributerDataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<string>> GetContributorFirstNames()
        {
            return await _context.Contributer.Select(x => x.FirstName).ToListAsync();
        }
    }
}
