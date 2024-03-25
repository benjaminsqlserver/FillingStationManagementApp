using FillingStationManagementApp.Application.Handlers;
using FillingStationManagementApp.Core.Repositories;
using FillingStationManagementApp.Core.Repositories.Base;
using FillingStationManagementApp.Infrastructure.Data;
using FillingStationManagementApp.Infrastructure.Repositories;
using FillingStationManagementApp.Infrastructure.Repositories.Base;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text.Json.Serialization;

namespace FillingStationManagementApp.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddJsonOptions(x =>x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);
            services.AddApiVersioning();
            services.AddDbContext<FillingStationDBContext>(m => m.UseSqlServer(Configuration.GetConnectionString("FillingStationConnection")), ServiceLifetime.Singleton);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(name: "v1", new OpenApiInfo { Title = "Filling Station Management API", Version = "v1" });
            }
            );
            services.AddAutoMapper(typeof(Startup));
            services.AddMediatR(typeof(CreateFuelTypeCommandHandler).GetTypeInfo().Assembly);
            services.AddScoped(typeof(IInt32Repository<>), typeof(Int32Repository<>));
            services.AddScoped(typeof(IInt64Repository<>), typeof(Int64Repository<>));
            services.AddTransient<IFuelTypeRepository, FuelTypeRepository>();
            services.AddTransient<IFuelPriceRepository, FuelPriceRepository>();
            services.AddTransient<IFillingStationRepository, FillingStationRepository>();
            services.AddTransient<ITransactionRepository, TransactionRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();

        }

        // Configure method for startup
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            }
            );
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", name: "Filling Station Management API V1");
            }
            );
        }

    }
}
