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
    public class CreateFuelTypeCommandHandler : IRequestHandler<CreateFuelTypeCommand, FuelTypeResponse>
    {
        private readonly IFuelTypeRepository _FuelTypeRepository;

        public CreateFuelTypeCommandHandler(IFuelTypeRepository FuelTypeRepository)
        {
            _FuelTypeRepository = FuelTypeRepository;
        }
        public async Task<FuelTypeResponse> Handle(CreateFuelTypeCommand request, CancellationToken cancellationToken)
        {
            FuelType FuelTypeEntity = FuelTypeMapper.Mapper.Map<FuelType>(request);
            if (FuelTypeEntity is null)
            {
                throw new ApplicationException("There Is An Issue With Mapping...");
            }

            var newFuelType = await _FuelTypeRepository.AddAsync(FuelTypeEntity);
            FuelTypeResponse FuelTypeResponse = FuelTypeMapper.Mapper.Map<FuelTypeResponse>(newFuelType);
            return FuelTypeResponse;
        }
    }

}
