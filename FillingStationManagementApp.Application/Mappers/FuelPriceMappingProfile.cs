using AutoMapper;
using FillingStationManagementApp.Application.Commands;
using FillingStationManagementApp.Application.Responses;
using FillingStationManagementApp.Core.Entities;

namespace FillingStationManagementApp.Application.Mappers
{
    public class FuelPriceMappingProfile : Profile
    {
        public FuelPriceMappingProfile()
        {
            CreateMap<FuelPrice, FuelPriceResponse>().ReverseMap();
            CreateMap<FuelPrice, CreateFuelPriceCommand>().ReverseMap();
        }
    }
}