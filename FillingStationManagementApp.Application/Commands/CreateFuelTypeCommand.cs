using FillingStationManagementApp.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Application.Commands
{
    public class CreateFuelTypeCommand : IRequest<FuelTypeResponse>
    {
        public string FuelName { get; set; }

        public string Description { get; set; }
    }
}
