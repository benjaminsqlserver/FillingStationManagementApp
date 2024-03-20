using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Application.Responses
{
    public class EmployeeResponse
    {
        public long Id { get; set; }
        public string FirstName { get; set; }


        public string LastName { get; set; }


        public string Position { get; set; }


        public long FillingStationID { get; set; }
    }
}
