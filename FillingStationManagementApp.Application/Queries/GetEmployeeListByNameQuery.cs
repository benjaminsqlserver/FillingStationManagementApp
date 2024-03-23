using FillingStationManagementApp.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Application.Queries
{
    public class GetEmployeeListByNameQuery:IRequest<IEnumerable<EmployeeResponse>>
    {
        public GetEmployeeListByNameQuery(string employeeFirstNameOrLastName)
        {
            EmployeeFirstNameOrLastName = employeeFirstNameOrLastName;
        }

        public string EmployeeFirstNameOrLastName { get; set; }

        
    }
}
