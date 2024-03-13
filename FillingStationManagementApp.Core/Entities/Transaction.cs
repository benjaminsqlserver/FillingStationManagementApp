using FillingStationManagementApp.Core.Entities.Base;

namespace FillingStationManagementApp.Core.Entities
{
    public class Transaction:Integer64KeyEntity
    {
        public long? StationID { get; set; }

        public FillingStation FillingStation { get; set; }

        public long? EmployeeID { get; set; }

        public Employee Employee { get; set; }

        public int? FuelTypeID { get; set; }

        public FuelType FuelType { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? Amount { get; set; }

        public DateTime? TransactionDate { get; set; }

    }
}