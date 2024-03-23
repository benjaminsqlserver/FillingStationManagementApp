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
    public class GetPriceListForFillingStationHandler : IRequestHandler<GetPriceListForFillingStationQuery, IEnumerable<FuelPriceResponse>>
    {
        private readonly IFuelPriceRepository _fuelPriceRepository;

        public GetPriceListForFillingStationHandler(IFuelPriceRepository fuelPriceRepository)
        {
            _fuelPriceRepository = fuelPriceRepository;
        }

        public async Task<IEnumerable<FuelPriceResponse>> Handle(GetPriceListForFillingStationQuery request, CancellationToken cancellationToken)
        {
            var priceList = await _fuelPriceRepository.GetPriceListForFillingStation(request.FillingStationName);
            var priceListResponse = FuelPriceMapper.Mapper.Map<IEnumerable<FuelPriceResponse>>(priceList);
            return priceListResponse;
        }
    }
}
