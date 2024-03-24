using FillingStationManagementApp.API;
using Microsoft.OpenApi.Writers;
using FillingStationManagementApp.Infrastructure.Data;

namespace FillingStationManagementApp.API
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            await CreateAndSeedDb(host);
            host.Run();
        }

        private static async Task CreateAndSeedDb(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var loggerFactory = services.GetRequiredService<ILoggerFactory>();
                try
                {
                    var fillingStationContext = services.GetRequiredService<FillingStationDBContext>();
                    await FillingStationContextSeed.SeedAsync(fillingStationContext, loggerFactory);

                }
                catch (Exception ex)
                {
                    var logger = loggerFactory.CreateLogger<Program>();
                    logger.LogError($"Exception Occurred In API: {ex.Message}");
                }
            }
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
         => Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
    }
}
