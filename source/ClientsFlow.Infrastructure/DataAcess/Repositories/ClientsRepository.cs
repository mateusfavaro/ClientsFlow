using ClientsFlow.Domain.Entities;
using ClientsFlow.Domain.Repositories.Clients;

namespace ClientsFlow.Infrastructure.DataAcess.Repositories
{
    internal class ClientsRepository : IClientsRepository
    {

        private readonly ClientsDataBaseContext _dbContext;

        public ClientsRepository(ClientsDataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Client client)
        {
            _dbContext.Clients.Add(client);

            _dbContext.SaveChanges();

        }
    }
}
