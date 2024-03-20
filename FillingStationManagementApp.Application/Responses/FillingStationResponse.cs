using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Application.Responses
{
    public class FillingStationResponse
    {
        public long Id { get; set; }
        public string StationName { get; set; }

        public string Location { get; set; }

        public long? ManagerID { get; set; }
    }
}
