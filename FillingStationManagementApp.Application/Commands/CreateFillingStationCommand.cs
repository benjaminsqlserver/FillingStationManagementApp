using FillingStationManagementApp.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Application.Commands
{
    public class CreateFillingStationCommand : IRequest<FillingStationResponse>
    {
        public string StationName { get; set; }

        public string Location { get; set; }

        public long? ManagerID { get; set; }
    }
}
