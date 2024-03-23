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
    public class GetFuelTypeByNameHandler : IRequestHandler<GetFuelTypeByNameQuery, FuelTypeResponse>
    {
        private readonly IFuelTypeRepository _fuelTypeRepository;

        public GetFuelTypeByNameHandler(IFuelTypeRepository fuelTypeRepository)
        {
            _fuelTypeRepository = fuelTypeRepository;
        }

        public async Task<FuelTypeResponse> Handle(GetFuelTypeByNameQuery request, CancellationToken cancellationToken)
        {
            var fuelType = await _fuelTypeRepository.GetFuelTypeByName(request.FuelTypeName);
            var fuelTypeResponse = FuelTypeMapper.Mapper.Map<FuelTypeResponse>(fuelType);
            return fuelTypeResponse;
        }
    }
}
