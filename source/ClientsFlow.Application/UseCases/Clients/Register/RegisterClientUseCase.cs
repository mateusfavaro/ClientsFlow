using ClientsFlow.Communication.Requests;
using ClientsFlow.Communication.Responses;
using ClientsFlow.Domain.Entities;
using ClientsFlow.Domain.Repositories.Clients;

namespace ClientsFlow.Application.UseCases.Clients.Register
{
    public class RegisterClientUseCase : IRegisterClientUseCase
    {

        private readonly IClientsRepository _repository;
        private readonly IUnitOfWork _unitOfWork;


        public RegisterClientUseCase(IClientsRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

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

            _repository.Add(entity);
            _unitOfWork.SaveDB();


            return new ResponseRegisterClientJson();
        }

        private void Validate(RequestRegisterClientJson request)
        {
            var Validator = new RegisterClientsValidator();
            Validator.Validator(request);
        }


    }
}
