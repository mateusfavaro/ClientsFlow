using ClientsFlow.Application.UseCases.Clients.Register;
using ClientsFlow.Communication.Requests;
using Microsoft.AspNetCore.Mvc;

/*O Projeto precisará conter (21/08/25):
 * Endpoint para registrar um cliente; -- feito
 * Regras de negocio; -- feito
 * Tratamento de erros; -- feito
 * Tratamento de excessões; -- feito
 * Lista de erros; -- feito
 * Erros em outros idiomas;
 * Testes unitários;
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
