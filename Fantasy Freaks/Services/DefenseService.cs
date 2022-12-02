using Fantasy_Freaks.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Fantasy_Freaks.Services
{
    public class DefenseService : IDefenseService
    {
        private readonly FantasyDataContext _context;
        public DefenseService(FantasyDataContext context)
        {
            _context = context;
        }

        public async Task<DefenseDataModel> GetTeam(int ID)
        {
            return await _context.Defense.Where(x => x.ID == ID).FirstOrDefaultAsync();
        }

        public async Task<DefenseDataModel> GetTeam(string name)
        {
            return await _context.Defense.Where(x => x.TeamName == name).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<DefenseDataModel>> AllTeams()
        {
            return await _context.Defense.ToListAsync();
        }

        public async Task<IEnumerable<DefenseDataModel>> RandomTeams(int amount)
        {   
            var teams = await _context.Defense.ToListAsync();
            var rand = new Random();
            List<int> listNumbers = new List<int>();
            for (int i = 0; i < amount; i++)
            {
                int number;
                do
                {
                    number = rand.Next(0, teams.Count);
                } while (listNumbers.Contains(number));
                listNumbers.Add(number);
            }
            List<DefenseDataModel> randomTeams = new List<DefenseDataModel>();
            foreach(var number in listNumbers)
            {
                randomTeams.Add(teams[number]);
            }
            return randomTeams;
        }
    }
}
