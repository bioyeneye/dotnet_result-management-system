using System.Threading;
using System.Threading.Tasks;

namespace DataAccess.BaseRepository
{
    public interface IUnitOfWorkAsync : IUnitOfWork
    {
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}