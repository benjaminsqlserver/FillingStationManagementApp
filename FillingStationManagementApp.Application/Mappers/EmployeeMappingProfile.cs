using AutoMapper;
using FillingStationManagementApp.Application.Commands;
using FillingStationManagementApp.Application.Responses;
using FillingStationManagementApp.Core.Entities;

namespace FillingStationManagementApp.Application.Mappers
{
    public class EmployeeMappingProfile : Profile
    {
        public EmployeeMappingProfile()
        {
            CreateMap<Employee, EmployeeResponse>().ReverseMap();
            CreateMap<Employee, CreateEmployeeCommand>().ReverseMap();
        }
    }
}