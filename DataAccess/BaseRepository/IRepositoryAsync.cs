using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccess.BaseRepository
{
    public interface IRepositoryAsync<TEntity> : IRepository<TEntity> where TEntity : class
    {
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        Task<TEntity> FindAsync(params object[] keyValues);
        Task<TEntity> FindAsync(CancellationToken cancellationToken, params object[] keyValues);
        Task<bool> DeleteAsync(params object[] keyValues);
        Task<bool> DeleteAsync(CancellationToken cancellationToken, params object[] keyValues);
    }
}
