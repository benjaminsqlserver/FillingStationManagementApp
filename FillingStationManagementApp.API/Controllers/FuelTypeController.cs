using FillingStationManagementApp.Application.Commands;
using FillingStationManagementApp.Application.Queries;
using FillingStationManagementApp.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FillingStationManagementApp.API.Controllers
{
    
    public class FuelTypeController  : ApiController
    {
        private readonly IMediator _mediator;

        public FuelTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<FuelTypeResponse>>> GetFuelTypeByName(string fuelTypeName)
        {
            var query = new GetFuelTypeByNameQuery(fuelTypeName);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<FuelTypeResponse>> CreateFuelType([FromBody] CreateFuelTypeCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

       


    }
}
