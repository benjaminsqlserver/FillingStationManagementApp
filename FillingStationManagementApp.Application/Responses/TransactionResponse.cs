using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Application.Responses
{
    public class TransactionResponse
    {
        public long Id { get; set; }
        public long? StationID { get; set; }



        public long? EmployeeID { get; set; }



        public int? FuelTypeID { get; set; }



        public decimal? Quantity { get; set; }

        public decimal? Amount { get; set; }

        public DateTime? TransactionDate { get; set; }
    }
}
