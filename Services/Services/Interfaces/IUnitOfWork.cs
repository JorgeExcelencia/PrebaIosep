using ApiIosep.Repositorio.Interfaces;

namespace ApiIosep.Services.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task BeginTransactionAsync();
        Task CommitAsync();
        Task RollbackAsync();
    }
}
