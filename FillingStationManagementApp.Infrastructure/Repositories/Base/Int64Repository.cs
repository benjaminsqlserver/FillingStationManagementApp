using FillingStationManagementApp.Core.Entities.Base;
using FillingStationManagementApp.Core.Repositories.Base;
using FillingStationManagementApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Infrastructure.Repositories.Base
{
    public class Int64Repository<T> : IInt64Repository<T> where T : Integer64KeyEntity
    {
        protected readonly FillingStationDBContext _fillingStationDBContext;

        public Int64Repository(FillingStationDBContext fillingStationDBContext)
        {
            _fillingStationDBContext = fillingStationDBContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _fillingStationDBContext.Set<T>().AddAsync(entity);
            await _fillingStationDBContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _fillingStationDBContext.Set<T>().Remove(entity);
            await _fillingStationDBContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _fillingStationDBContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(long id)
        {
            return await _fillingStationDBContext.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _fillingStationDBContext.Entry(entity).State = EntityState.Modified;
            await _fillingStationDBContext.SaveChangesAsync();
        }
    }

}
