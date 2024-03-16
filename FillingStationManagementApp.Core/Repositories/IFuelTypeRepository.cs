using FillingStationManagementApp.Core.Entities;
using FillingStationManagementApp.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Core.Repositories
{
    public interface IFuelTypeRepository:IInt32Repository<FuelType>
    {
        //place all custom operations for FuelType entity here
        Task<FuelType> GetFuelTypeByName(string fuelTypeName);
    }
}
