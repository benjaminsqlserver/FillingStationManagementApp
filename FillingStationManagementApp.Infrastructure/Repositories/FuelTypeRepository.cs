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
    public class FuelTypeRepository : Int32Repository<FuelType>, IFuelTypeRepository
    {
        public FuelTypeRepository(FillingStationDBContext fillingStationDBContext) : base(fillingStationDBContext)
        {
        }

        public async Task<FuelType> GetFuelTypeByName(string fuelTypeName)
        {
            return await _fillingStationDBContext.FuelTypes.FirstOrDefaultAsync(p => p.FuelName == fuelTypeName);

        }
    }

}
