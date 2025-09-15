using ClientsFlow.Application.UseCases.Clients.GetAll;
using ClientsFlow.Application.UseCases.Clients.Register;
using ClientsFlow.Communication.Requests;
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
        public async Task<IActionResult> GetAllClients([FromServices] IGetClientsUseCase useCase)
        {

            var response = await useCase.Execute();

            return Ok(response);

        }



        //Endpoint para recuperar uma despesa por ID
        //Configurar exceção e filtro para um notfound id



    }
}
