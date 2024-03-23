using FillingStationManagementApp.Application.Mappers;
using FillingStationManagementApp.Application.Queries;
using FillingStationManagementApp.Application.Responses;
using FillingStationManagementApp.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingStationManagementApp.Application.Handlers
{
    public class GetTransactionListForFillingStationHandler : IRequestHandler<GetTransactionListForFillingStationQuery, IEnumerable<TransactionResponse>>
    {
        private readonly ITransactionRepository _transactionRepository;

        public GetTransactionListForFillingStationHandler(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public async Task<IEnumerable<TransactionResponse>> Handle(GetTransactionListForFillingStationQuery request, CancellationToken cancellationToken)
        {
            var transactionList = await _transactionRepository.GetTransactionListForFillingStation(request.FillingStationName);
            var transactionListResponse = TransactionMapper.Mapper.Map<IEnumerable<TransactionResponse>>(transactionList);
            return transactionListResponse;
        }
    }
}
