using Fantasy_Freaks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Freaks.Interfaces
{
    public interface IPlayerPerformanceService
    {
        Task<IEnumerable<PlayerPerformanceDataModel>> AllPlayers(int week);
    }
}
