using ClientsFlow.Domain.Entities;

namespace ClientsFlow.Domain.Repositories.Clients
{


    //Interface que vai se comunicar com a classe que irá adicionar os dados do cliente ao banco de dados\\
    public interface IClientsRepository
    {

        Task Add(Client client);

        Task<List<Client>> GetAll();

    }
}
