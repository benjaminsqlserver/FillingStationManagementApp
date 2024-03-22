using FillingStationManagementApp.Application.Commands;
using FillingStationManagementApp.Application.Mappers;
using FillingStationManagementApp.Application.Responses;
using FillingStationManagementApp.Core.Entities;
using FillingStationManagementApp.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Application.Handlers
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, EmployeeResponse>
    {
        private readonly IEmployeeRepository _EmployeeRepository;

        public CreateEmployeeCommandHandler(IEmployeeRepository EmployeeRepository)
        {
            _EmployeeRepository = EmployeeRepository;
        }
        public async Task<EmployeeResponse> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            Employee EmployeeEntity = EmployeeMapper.Mapper.Map<Employee>(request);
            if (EmployeeEntity is null)
            {
                throw new ApplicationException("There Is An Issue With Mapping...");
            }

            var newEmployee = await _EmployeeRepository.AddAsync(EmployeeEntity);
            EmployeeResponse EmployeeResponse = EmployeeMapper.Mapper.Map<EmployeeResponse>(newEmployee);
            return EmployeeResponse;
        }
    }
}
