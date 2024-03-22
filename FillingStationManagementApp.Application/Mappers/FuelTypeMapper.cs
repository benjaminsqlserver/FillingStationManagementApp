using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Application.Mappers
{
    public class FuelTypeMapper
    {
        private static readonly Lazy<IMapper> lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<FuelTypeMappingProfile>();
            }

                );

            var mapper = config.CreateMapper();

            return mapper;
        }

        );

        public static IMapper Mapper => lazy.Value;
    }

}
