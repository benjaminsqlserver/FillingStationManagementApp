using FillingStationManagementApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Application.Responses
{
    public class FuelPriceResponse
    {
        public long Id { get; set; }
        public int FuelTypeID { get; set; }

        public FuelType FuelType { get; set; }

        public long FillingStationID { get; set; }




        public decimal? Price { get; set; }
    }
}
