using FillingStationManagementApp.Application.Commands;
using FillingStationManagementApp.Application.Queries;
using FillingStationManagementApp.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FillingStationManagementApp.API.Controllers
{

    public class TransactionController : ApiController
    {
        private readonly IMediator _mediator;

        public TransactionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<TransactionResponse>>> GetTransactionListForFillingStation(string fillingStationName)
        {
            var query = new GetTransactionListForFillingStationQuery(fillingStationName);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<TransactionResponse>> CreateTransaction([FromBody] CreateTransactionCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }




    }
}
