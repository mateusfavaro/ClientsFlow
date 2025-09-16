using ClientsFlow.Application.UseCases.Clients.GetAll;
using ClientsFlow.Application.UseCases.Clients.GetById;
using ClientsFlow.Application.UseCases.Clients.Register;
using ClientsFlow.Communication.Requests;
using ClientsFlow.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace ClientsFlow.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> RegisterClients(
            [FromServices] IRegisterClientUseCase useCase,
            [FromBody] RequestRegisterClientJson request
            )
        {
            var response = await useCase.RegisterClient(request);
            return Created(string.Empty, response);
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseClientJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAllClients([FromServices] IGetClientsUseCase useCase)
        {

            var response = await useCase.Execute();

            return Ok(response);

        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponseClientJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(
            [FromServices] IGetClientByIdUseCase useCase,
            [FromRoute] long id)
        {
            var response = await useCase.Execute(id);

            return Ok(response);
        }





    }
}
