using ClientsFlow.Communication.Requests;
using ClientsFlow.Communication.Responses;

namespace ClientsFlow.Application.UseCases.Clients.Register
{
    public class RegisterClientUseCase
    {

        public ResponseRegisterClientJson RegisterClient(RequestRegisterClientJson request)
        {

            var Validator = new RegisterClientsValidator();
            Validator.Validator(request);

            return new ResponseRegisterClientJson();
        }
    }
}
