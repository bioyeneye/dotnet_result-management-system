using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.BaseRepository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        int SaveChanges();
        TEntity Find(params object[] keyValues);
        TEntity Find(Expression<Func<TEntity, bool>> predicate);
        void Insert(TEntity entity, bool save = true);
        void InsertRange(IEnumerable<TEntity> entities, bool save = true);
        void Update(TEntity entity, bool save = true);
        void UpdateRange(IEnumerable<TEntity> entities, bool save = true);
        void Delete(object id, bool save = true);
        void Delete(TEntity entity, bool save = true);
        void DeleteRange(IEnumerable<TEntity> entities, bool save = true);
        void Clear();
        IQueryable<TEntity> Queryable();
        IQueryable<TEntity> Table { get; }
        IRepository<T> GetRepository<T>() where T : class;

    }
}
