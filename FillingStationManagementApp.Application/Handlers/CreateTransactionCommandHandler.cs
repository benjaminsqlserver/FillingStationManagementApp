using FillingStationManagementApp.Application.Commands;
using FillingStationManagementApp.Application.Mappers;
using FillingStationManagementApp.Application.Responses;
using FillingStationManagementApp.Core.Entities;
using FillingStationManagementApp.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Application.Handlers
{
    public class CreateTransactionCommandHandler : IRequestHandler<CreateTransactionCommand, TransactionResponse>
    {
        private readonly ITransactionRepository _TransactionRepository;

        public CreateTransactionCommandHandler(ITransactionRepository TransactionRepository)
        {
            _TransactionRepository = TransactionRepository;
        }
        public async Task<TransactionResponse> Handle(CreateTransactionCommand request, CancellationToken cancellationToken)
        {
            Transaction TransactionEntity = TransactionMapper.Mapper.Map<Transaction>(request);
            if (TransactionEntity is null)
            {
                throw new ApplicationException("There Is An Issue With Mapping...");
            }

            var newTransaction = await _TransactionRepository.AddAsync(TransactionEntity);
            TransactionResponse TransactionResponse = TransactionMapper.Mapper.Map<TransactionResponse>(newTransaction);
            return TransactionResponse;
        }
    }
}
