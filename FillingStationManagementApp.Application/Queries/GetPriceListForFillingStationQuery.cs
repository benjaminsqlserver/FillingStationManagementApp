using FillingStationManagementApp.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Application.Queries
{
    public class GetPriceListForFillingStationQuery : IRequest<IEnumerable<FuelPriceResponse>>
    {
        public GetPriceListForFillingStationQuery(string fillingStationName)
        {
            FillingStationName = fillingStationName;
        }

        public string FillingStationName { get; set; }

        
    }
}
