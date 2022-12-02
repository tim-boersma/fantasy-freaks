﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Freaks.Models
{
    public interface IPreviousPlayerService
    {
        Task<IEnumerable<LastSeasonPlayerDataModel>> GetAllPlayers();
        Task<IEnumerable<LastSeasonPlayerDataModel>> GetAllQuarterbacks();
        Task<IEnumerable<LastSeasonPlayerDataModel>> GetAllRunningbacks();
        Task<IEnumerable<LastSeasonPlayerDataModel>> GetAllWideReceivers();
        Task<IEnumerable<LastSeasonPlayerDataModel>> GetAllTightEnds();
    }
}
