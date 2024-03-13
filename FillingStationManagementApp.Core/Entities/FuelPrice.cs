using FillingStationManagementApp.Core.Entities.Base;


namespace FillingStationManagementApp.Core.Entities
{
    public class FuelPrice:Integer64KeyEntity
    {
        public FuelType FuelType { get; set; }

        

        public FillingStation FillingStation { get; set; }

        public decimal? Price { get; set; }

    }
}