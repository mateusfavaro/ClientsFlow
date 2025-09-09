using ClientsFlow.Application.UseCases.Clients.Register;
using ClientsFlow.Communication.Requests;
using Microsoft.AspNetCore.Mvc;

/*CONTINUAÇÃO
 * Deverá ser configurado um banco de dados MYSQL para armazenar os dados da API
 * Construir injeção de dependencia;
*/

namespace ClientsFlow.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {

        [HttpPost]
        public IActionResult RegisterClients(
            [FromServices] IRegisterClientUseCase useCase,
            [FromBody] RequestRegisterClientJson request
            )
        {

            var response = useCase.RegisterClient(request);
            return Created(string.Empty, response);
        }
    }
}
