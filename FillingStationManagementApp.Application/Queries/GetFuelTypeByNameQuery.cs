using FillingStationManagementApp.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Application.Queries
{
    public class GetFuelTypeByNameQuery:IRequest<FuelTypeResponse>
    {
        public string FuelTypeName { get; set; }

        public GetFuelTypeByNameQuery(string fuelTypeName)
        {
            FuelTypeName= fuelTypeName;
        }

    }
}
