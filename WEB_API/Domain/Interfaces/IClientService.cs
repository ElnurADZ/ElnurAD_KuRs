using Domain.Models;

namespace Domain.Interfaces
{
    public interface IClientService
    {
        Task<List<Client>> GetAll();
        Task<Client> GetOne(int Get_one_id);
        Task Create(Client model);
        Task Update(Client model);
        Task Delete(int id);
    }
}
