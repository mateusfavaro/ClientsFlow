using ClientsFlow.Communication.Requests;
using ClientsFlow.Communication.Responses;

namespace ClientsFlow.Application.UseCases.Clients.Register
{
    public interface IRegisterClientUseCase
    {

        ResponseRegisterClientJson RegisterClient(RequestRegisterClientJson request);

    }
}
