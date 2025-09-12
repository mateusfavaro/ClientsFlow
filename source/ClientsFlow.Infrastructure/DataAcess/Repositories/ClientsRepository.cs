using ClientsFlow.Domain.Entities;
using ClientsFlow.Domain.Repositories.Clients;
using Microsoft.EntityFrameworkCore;

namespace ClientsFlow.Infrastructure.DataAcess.Repositories
{
    internal class ClientsRepository : IClientsRepository
    {

        private readonly ClientsDataBaseContext _dbContext;

        public ClientsRepository(ClientsDataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(Client client)
        {
            await _dbContext.Clients.AddAsync(client);

        }

        public async Task<List<Client>> GetAll()
        {
            
            return await _dbContext.Clients.ToListAsync();

        }
    }
}
