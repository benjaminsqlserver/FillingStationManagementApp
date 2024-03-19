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
    public class EmployeeRepository : Int64Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(FillingStationDBContext fillingStationDBContext) : base(fillingStationDBContext)
        {
        }

        public async Task<IEnumerable<Employee>> GetEmployeeListByName(string employeeFirstNameOrLastName)
        {
            return await _fillingStationDBContext.Employees.Where(p => p.FirstName == employeeFirstNameOrLastName || p.LastName==employeeFirstNameOrLastName ).ToListAsync();

        }
    }
}
