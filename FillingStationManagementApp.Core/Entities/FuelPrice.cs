using FillingStationManagementApp.Core.Entities.Base;


namespace FillingStationManagementApp.Core.Entities
{
    public class FuelPrice:Integer64KeyEntity
    {
        public int FuelTypeID { get; set; }

        public FuelType FuelType { get; set; }

        public long FillingStationID { get; set; }


        public FillingStation FillingStation { get; set; }

        public decimal? Price { get; set; }

    }
}