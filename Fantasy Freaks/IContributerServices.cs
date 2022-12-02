using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Freaks
{
    public interface IContributerServices 
    {
        Task<IEnumerable<string>> GetContributorFirstNames();
    }
}
