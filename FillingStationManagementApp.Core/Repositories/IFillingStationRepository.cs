using FillingStationManagementApp.Core.Entities;
using FillingStationManagementApp.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Core.Repositories
{
    public interface IFillingStationRepository:IInt64Repository<FillingStation>
    {
        //place all custom operations for Filling Station entity here
        Task<FillingStation> GetFillingStationByName(string fillingStationName);
    }
}
