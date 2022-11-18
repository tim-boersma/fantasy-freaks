using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Fantasy_Freaks
{
    public class ContributerService : IContributerService
    {
        private readonly ContributerDataContext _context;
        public ContributerService(ContributerDataContext context)
        {
            _context = context;
        }

        public string SayHello()
        {
            return "Hello, world!";
        }

        public async Task<string> AllContributers()
        {
            var user = await _context.Contributer.SingleAsync(x => x.FirstName == "Timothy");
            return user.FirstName;
        }
    }
}
