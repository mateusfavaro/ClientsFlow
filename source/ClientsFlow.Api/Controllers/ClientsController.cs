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
        public IActionResult RegisterClients([FromBody] RequestRegisterClientJson request)
        {

            var useCase = new RegisterClientUseCase();
            var response = useCase.RegisterClient(request);

            return Created(string.Empty, response);

        }
    }
}
