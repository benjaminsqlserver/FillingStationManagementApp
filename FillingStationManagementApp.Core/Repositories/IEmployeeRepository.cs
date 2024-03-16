using FillingStationManagementApp.Core.Entities;
using FillingStationManagementApp.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Core.Repositories
{
    public interface IEmployeeRepository:IInt64Repository<Employee>
    {
        //place all custom operations for Employee entity here
        Task<IEnumerable<Employee>> GetEmployeeListByName(string employeeFirstNameOrLastName);
    }
}
