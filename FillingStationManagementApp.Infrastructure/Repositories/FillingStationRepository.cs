using FillingStationManagementApp.Core.Entities;
using FillingStationManagementApp.Core.Repositories;
using FillingStationManagementApp.Infrastructure.Data;
using FillingStationManagementApp.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Infrastructure.Repositories
{
    public class FillingStationRepository : Int64Repository<FillingStation>, IFillingStationRepository
    {
        public FillingStationRepository(FillingStationDBContext fillingStationDBContext) : base(fillingStationDBContext)
        {
        }

        public async Task<FillingStation> GetFillingStationByName(string fillingStationName)
        {
            return await _fillingStationDBContext.FillingStations.FirstOrDefaultAsync(p => p.StationName==fillingStationName);
        }
    }
}
