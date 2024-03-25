using FillingStationManagementApp.Application.Commands;
using FillingStationManagementApp.Application.Queries;
using FillingStationManagementApp.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FillingStationManagementApp.API.Controllers
{

    public class FillingStationController : ApiController
    {
        private readonly IMediator _mediator;

        public FillingStationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<FillingStationResponse>> GetFillingStationByName(string FillingStationName)
        {
            var query = new GetFillingStationByNameQuery(FillingStationName);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<FillingStationResponse>> CreateFillingStation([FromBody] CreateFillingStationCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }




    }
}
