using FillingStationManagementApp.Application.Commands;
using FillingStationManagementApp.Application.Queries;
using FillingStationManagementApp.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FillingStationManagementApp.API.Controllers
{

    public class FuelPriceController : ApiController
    {
        private readonly IMediator _mediator;

        public FuelPriceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<FuelPriceResponse>>> GetFuelPriceListForFillingStation(string fillingStationName)
        {
            var query = new GetPriceListForFillingStationQuery(fillingStationName);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<FuelPriceResponse>> CreateFuelPrice([FromBody] CreateFuelPriceCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }




    }
}
