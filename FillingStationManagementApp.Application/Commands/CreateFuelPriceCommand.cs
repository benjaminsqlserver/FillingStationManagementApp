using FillingStationManagementApp.Application.Responses;
using FillingStationManagementApp.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Application.Commands
{
    public class CreateFuelPriceCommand : IRequest<FuelPriceResponse>
    {
        public int FuelTypeID { get; set; }

        public FuelType FuelType { get; set; }

        public long FillingStationID { get; set; }


        

        public decimal? Price { get; set; }
    }
}
