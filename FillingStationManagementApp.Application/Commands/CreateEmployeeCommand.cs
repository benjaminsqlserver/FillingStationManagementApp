using FillingStationManagementApp.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Application.Commands
{
    public class CreateEmployeeCommand : IRequest<EmployeeResponse>
    {
        public string FirstName { get; set; }


        public string LastName { get; set; }


        public string Position { get; set; }


        public long FillingStationID { get; set; }
    }
}
