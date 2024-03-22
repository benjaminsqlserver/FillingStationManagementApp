
using FillingStationManagementApp.Application.Commands;
using FillingStationManagementApp.Application.Responses;
using FillingStationManagementApp.Core.Entities;
using FillingStationManagementApp.Core.Repositories;
using FuelPriceManagementApp.Application.Mappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelPriceManagementApp.Application.Handlers
{
    public class CreateFuelPriceCommandHandler : IRequestHandler<CreateFuelPriceCommand, FuelPriceResponse>
    {
        private readonly IFuelPriceRepository _FuelPriceRepository;

        public CreateFuelPriceCommandHandler(IFuelPriceRepository FuelPriceRepository)
        {
            _FuelPriceRepository = FuelPriceRepository;
        }
        public async Task<FuelPriceResponse> Handle(CreateFuelPriceCommand request, CancellationToken cancellationToken)
        {
            FuelPrice FuelPriceEntity = FuelPriceMapper.Mapper.Map<FuelPrice>(request);
            if (FuelPriceEntity is null)
            {
                throw new ApplicationException("There Is An Issue With Mapping...");
            }

            var newFuelPrice = await _FuelPriceRepository.AddAsync(FuelPriceEntity);
            FuelPriceResponse FuelPriceResponse = FuelPriceMapper.Mapper.Map<FuelPriceResponse>(newFuelPrice);
            return FuelPriceResponse;
        }
    }
}
