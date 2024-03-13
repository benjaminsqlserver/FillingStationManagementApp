using FillingStationManagementApp.Core.Entities.Base;

namespace FillingStationManagementApp.Core.Entities
{
    public class FillingStation:Integer64KeyEntity
    {
        public string StationName { get; set; }

        public string Location { get; set; }

        public long? ManagerID { get; set; }

        public Employee Employee { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public ICollection<FuelPrice> FuelPrices { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}