﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelPriceManagementApp.Application.Mappers
{
    public class FuelPriceMapper
    {
        private static readonly Lazy<IMapper> lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<FuelPriceMappingProfile>();
            }

                );

            var mapper = config.CreateMapper();

            return mapper;
        }

        );

        public static IMapper Mapper => lazy.Value;
    }
}
