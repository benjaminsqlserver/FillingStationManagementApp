using FillingStationManagementApp.Core.Entities.Base;


namespace FillingStationManagementApp.Core.Entities
{
    public class Employee:Integer64KeyEntity
    {
        
        public string FirstName { get; set; }

        
        public string LastName { get; set; }

        
        public string Position { get; set; }

        
        public long FillingStationID { get; set; }

        public FillingStation FillingStation { get; set; }

        public ICollection<FillingStation> FillingStations { get; set; }

        public ICollection<Transaction> Transactions { get; set; }

    }
}