using FillingStationManagementApp.Application.Commands;
using FillingStationManagementApp.Application.Queries;
using FillingStationManagementApp.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FillingStationManagementApp.API.Controllers
{

    public class EmployeeController : ApiController
    {
        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<EmployeeResponse>>> GetEmployeeListByName(string EmployeeName)
        {
            var query = new GetEmployeeListByNameQuery(EmployeeName);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<EmployeeResponse>> CreateEmployee([FromBody] CreateEmployeeCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }




    }
}
