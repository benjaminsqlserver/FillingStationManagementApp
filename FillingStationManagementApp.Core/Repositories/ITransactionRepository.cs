using FillingStationManagementApp.Core.Entities;
using FillingStationManagementApp.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Core.Repositories
{
    public interface ITransactionRepository:IInt64Repository<Transaction>
    {
        //place all custom operations for Transaction entity here
        Task<IEnumerable<Transaction>> GetTransactionListForFillingStation(string fillingStationName);
    }
}
