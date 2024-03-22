using AutoMapper;
using FillingStationManagementApp.Application.Commands;
using FillingStationManagementApp.Application.Responses;
using FillingStationManagementApp.Core.Entities;

namespace FillingStationManagementApp.Application.Mappers
{
    public class FillingStationMappingProfile : Profile
    {
        public FillingStationMappingProfile()
        {
            CreateMap<FillingStation, FillingStationResponse>().ReverseMap();
            CreateMap<FillingStation, CreateFillingStationCommand>().ReverseMap();
        }
    }
}