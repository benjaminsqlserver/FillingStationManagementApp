using FillingStationManagementApp.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Core.Entities
{
    public  class FuelType:Integer32KeyEntity
    {
        
        

        public string FuelName { get; set; }

        public string Description { get; set; }

        public ICollection<FuelPrice> FuelPrices { get; set; }

        public ICollection<Transaction> Transactions { get; set; }

    }

}
