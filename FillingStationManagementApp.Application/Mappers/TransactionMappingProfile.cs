using AutoMapper;
using FillingStationManagementApp.Application.Commands;
using FillingStationManagementApp.Application.Responses;
using FillingStationManagementApp.Core.Entities;

namespace FillingStationManagementApp.Application.Mappers
{
    public class TransactionMappingProfile : Profile
    {
        public TransactionMappingProfile()
        {
            CreateMap<Transaction, TransactionResponse>().ReverseMap();
            CreateMap<Transaction, CreateTransactionCommand>().ReverseMap();
        }
    }
}