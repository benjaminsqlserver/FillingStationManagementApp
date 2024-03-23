using FillingStationManagementApp.Application.Mappers;
using FillingStationManagementApp.Application.Queries;
using FillingStationManagementApp.Application.Responses;
using FillingStationManagementApp.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Application.Handlers
{
    public class GetEmployeeListByNameHandler : IRequestHandler<GetEmployeeListByNameQuery, IEnumerable<EmployeeResponse>>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public GetEmployeeListByNameHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<IEnumerable<EmployeeResponse>> Handle(GetEmployeeListByNameQuery request, CancellationToken cancellationToken)
        {
            var employeeList = await _employeeRepository.GetEmployeeListByName(request.EmployeeFirstNameOrLastName);
            var employeeResponseList = EmployeeMapper.Mapper.Map<IEnumerable<EmployeeResponse>>(employeeList);
            return employeeResponseList;
        }
    }
}
