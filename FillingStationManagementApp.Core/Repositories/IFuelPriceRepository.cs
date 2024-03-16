using FillingStationManagementApp.Core.Entities;
using FillingStationManagementApp.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Core.Repositories
{
    public interface IFuelPriceRepository:IInt64Repository<FuelPrice>
    {
        //place all custom operations for Fuel Price entity here
        Task<IEnumerable<FuelPrice>> GetPriceListForFillingStation(string fillingStationName);
    }
}
