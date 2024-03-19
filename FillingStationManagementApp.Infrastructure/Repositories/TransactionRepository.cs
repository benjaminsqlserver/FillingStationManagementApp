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
    public class TransactionRepository : Int64Repository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(FillingStationDBContext fillingStationDBContext) : base(fillingStationDBContext)
        {
        }

        public async Task<IEnumerable<Transaction>> GetTransactionListForFillingStation(string fillingStationName)
        {
            return await _fillingStationDBContext.Transactions.Include(x => x.FillingStation).Where(p => p.FillingStation.StationName == fillingStationName).ToListAsync();
        }
    }
}
