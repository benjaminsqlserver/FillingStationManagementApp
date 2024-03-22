using AutoMapper;
using FillingStationManagementApp.Application.Commands;
using FillingStationManagementApp.Application.Responses;
using FillingStationManagementApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Application.Mappers
{
    public class FuelTypeMappingProfile : Profile
    {
        public FuelTypeMappingProfile()
        {
            CreateMap<FuelType, FuelTypeResponse>().ReverseMap();
            CreateMap<FuelType, CreateFuelTypeCommand>().ReverseMap();
        }
    }

}
