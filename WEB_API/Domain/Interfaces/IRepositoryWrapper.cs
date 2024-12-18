using Domain.Interfaces;

namespace Domain.Wrapper
{
    public interface IRepositoryWrapper
    {
        IClientRepository Client {  get; }
        Task Save();
    }
}
