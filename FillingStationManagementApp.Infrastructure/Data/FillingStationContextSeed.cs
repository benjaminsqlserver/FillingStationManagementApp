using FillingStationManagementApp.Core.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Infrastructure.Data
{
    public class FillingStationContextSeed
    {
        public static async Task SeedAsync(FillingStationDBContext fillingStationDBContext, ILoggerFactory loggerFactory, int? retry = 0)
        {
            int retryForAvailability = retry.Value;

            try
            {
                await fillingStationDBContext.Database.EnsureCreatedAsync();
                if (!fillingStationDBContext.FuelTypes.Any())
                {
                   
                    fillingStationDBContext.FuelTypes.AddRange(GetFuelTypes());
                    await fillingStationDBContext.SaveChangesAsync();

                }
                if (!fillingStationDBContext.FillingStations.Any())
                {
                    
                    fillingStationDBContext.FillingStations.AddRange(GetFillingStations());
                    await fillingStationDBContext.SaveChangesAsync();

                }
                if (!fillingStationDBContext.Employees.Any())
                {

                    fillingStationDBContext.Employees.AddRange(GetEmployees());
                    await fillingStationDBContext.SaveChangesAsync();

                }
                if (!fillingStationDBContext.FuelPrices.Any())
                {

                    fillingStationDBContext.FuelPrices.AddRange(GetFuelPrices());
                    await fillingStationDBContext.SaveChangesAsync();

                }
                if (!fillingStationDBContext.Transactions.Any())
                {

                    fillingStationDBContext.Transactions.AddRange(GetTransactions());
                    await fillingStationDBContext.SaveChangesAsync();

                }
            }
            catch (Exception ex)
            {
                if (retryForAvailability < 3)
                {
                    retryForAvailability++;
                    var log = loggerFactory.CreateLogger<FillingStationDBContext>();
                    log.LogError($"Exception Occurred While Connecting: {ex.Message}");
                    await SeedAsync(fillingStationDBContext, loggerFactory, retryForAvailability);

                }
            }
        }

        private static IEnumerable<Transaction> GetTransactions()
        {
            return new List<Transaction>()
            {
                new Transaction{ Amount=7557M, EmployeeID=1, FuelTypeID=1, Quantity=5, StationID=1, TransactionDate=DateTime.Now},
                 new Transaction{ Amount=8034M, EmployeeID=2, FuelTypeID=2, Quantity=7, StationID=2, TransactionDate=DateTime.Now},




            };
        }

        private static IEnumerable<FuelPrice> GetFuelPrices()
        {
            return new List<FuelPrice>()
            {
                new FuelPrice{ FillingStationID=1, FuelTypeID=1, Price=345.37M },
                new FuelPrice{ FillingStationID=2, FuelTypeID=2, Price=956.34M },



            };
        }

        private static IEnumerable<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee{ FirstName="Chidi", LastName="Emeka", FillingStationID=1, Position="Attendant", Transactions=new List<Transaction>() },
                new Employee{ FirstName="Ali", LastName="Hamza", FillingStationID=2, Position="Attendant", Transactions=new List<Transaction>() },
                new Employee{ FirstName="Tunde", LastName="Ademola", FillingStationID=1, Position="Attendant", Transactions=new List<Transaction>() },


            };
        }

        private static IEnumerable<FillingStation> GetFillingStations()
        {
            return new List<FillingStation>()
            {
                new FillingStation{ Location="Ejigbo", StationName="GNPC Ejigbo", ManagerID=null, Employee=null, Employees=new List<Employee>(), FuelPrices=new List<FuelPrice>(), Transactions=new List<Transaction>()},
                new FillingStation{ Location="Ikotun", StationName="GNPC Ikotun", ManagerID=null, Employee=null, Employees=new List<Employee>(), FuelPrices=new List<FuelPrice>(), Transactions=new List<Transaction>()},

            };
        }

        private static IEnumerable<FuelType> GetFuelTypes()
        {
            return new List<FuelType>()
            {
                new FuelType{ FuelName="Petrol",Description="Petrol", FuelPrices=new List<FuelPrice>(),Transactions=new List<Transaction>()},
                new FuelType{ FuelName="Diesel",Description="Diesel", FuelPrices=new List<FuelPrice>(),Transactions=new List<Transaction>()},

            };
        }

        

    }
}
