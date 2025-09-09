using ClientsFlow.Communication.Requests;
using ClientsFlow.Communication.Responses;
using ClientsFlow.Domain.Entities;

namespace ClientsFlow.Application.UseCases.Clients.Register
{
    public class RegisterClientUseCase
    {

        public ResponseRegisterClientJson RegisterClient(RequestRegisterClientJson request)
        {

            Validate(request);

            var entity = new Client
            {
                ClientName = request.ClientName,
                AmountCharged = request.AmountCharged,
                ServiceDescription = request.ServiceDescription,
                AreaOfActivity = (Domain.Enums.AreaOfActivity)request.AreaOfActivity,
            };

            return new ResponseRegisterClientJson();
        }

        private void Validate(RequestRegisterClientJson request)
        {
            var Validator = new RegisterClientsValidator();
            Validator.Validator(request);
        }


    }
}
