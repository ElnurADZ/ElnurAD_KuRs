using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;


namespace BusinessLogic.Services
{
    public class ClientService : IClientService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public ClientService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<Client>> GetAll()
        {
            return await _repositoryWrapper.Client.GetAll();
        }

        public async Task<Client> GetOne(int id)
        {
            var user = await _repositoryWrapper.Client
                .GetOne(x => x.IdClients == id);
            return user.First();
        }

        public async Task Create(Client model)
        {
            await _repositoryWrapper.Client.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(Client model)
        {
            _repositoryWrapper.Client.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var user = await _repositoryWrapper.Client
                .GetOne(x => x.IdClients == id);

            _repositoryWrapper.Client.Delete(user.First());
            _repositoryWrapper.Save();
        }
    }
}