#region

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

#endregion

namespace DataAccess.BaseRepository
{
    public class Repository<TEntity> : IRepositoryAsync<TEntity> where TEntity : class
    {
        #region Private Fields

        protected readonly IDataContextAsync _context;
        private readonly IUnitOfWorkAsync _unitOfWork;
        protected readonly DbSet<TEntity> _dbSet;


        #endregion Private Fields

        public Repository(IDataContextAsync context,IUnitOfWorkAsync unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;

            // Temporarily for FakeDbContext, Unit Test and Fakes
            var dbContext = context as DbContext;


            if (dbContext != null)
            {
                _dbSet = dbContext.Set<TEntity>();
            }
            else
            {

            }
        }


        public virtual IQueryable<TEntity> Table => Queryable();

        public virtual TEntity Find(params object[] keyValues)
        {
            return _dbSet.Find(keyValues);
        }

        public virtual TEntity Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Table.SingleOrDefault(predicate);
        }

        public virtual TEntity Find(object id)
        {
            return _dbSet.Find(id);
        }


        public virtual void Insert(TEntity entity, bool saveNow = true)
        {
            ((DbContext)_context).Entry(entity).State = EntityState.Added;
            if (saveNow)
                _context.SaveChanges();
        }

        public virtual void InserRange(IEnumerable<TEntity> entities, bool saveNow = true)
        {
            foreach (var entity in entities)
            {
                Insert(entity);
            }
            if (saveNow)
                _context.SaveChanges();
        }


        public virtual void Update(TEntity entity, bool saveNow = true)
        {
           ((DbContext) _context).Entry(entity).State=EntityState.Modified;
            if (saveNow)
                _context.SaveChanges();
        }

        public  void Delete(object id, bool saveNow = true)
        {
            var entity = _dbSet.Find(id);
            Delete(entity);
            if (saveNow)
                _context.SaveChanges();
        }

        public virtual void Delete(TEntity entity, bool saveNow = true)
        {
            ((DbContext)_context).Entry(entity).State = EntityState.Deleted;
            if (saveNow)
                _context.SaveChanges();
        }
        public virtual async Task<TEntity> GetAsync(params object[] keyValues)
        {
            return await _dbSet.FindAsync(keyValues);
        }

        public virtual async Task<TEntity> GetAsync(CancellationToken cancellationToken, params object[] keyValues)
        {
            return await _dbSet.FindAsync(cancellationToken, keyValues);
        }

        public virtual async Task<bool> DeleteAsync(params object[] keyValues)
        {
            return await DeleteAsync(CancellationToken.None, keyValues);
        }

        public virtual async Task<bool> DeleteAsync(CancellationToken cancellationToken, params object[] keyValues)
        {
            var entity = await GetAsync(cancellationToken, keyValues);

            if (entity == null)
            {
                return false;
            }

            ((DbContext)_context).Entry(entity).State = EntityState.Deleted;

            return true;
        }


        public virtual void SaveChangesAsny()
        {
            _context.SaveChangesAsync();
        }

        public virtual int SaveChanges()
        {
          return  _context.SaveChanges();
        }

        public virtual Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public virtual Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }

        public virtual Task<TEntity> FindAsync(params object[] keyValues)
        {
            return FindAsync(CancellationToken.None, keyValues);
        }

        public virtual Task<TEntity> FindAsync(CancellationToken cancellationToken, params object[] keyValues)
        {
            return _dbSet.FindAsync(cancellationToken, keyValues);
        }



        public virtual void InsertRange(IEnumerable<TEntity> entities, bool save = true)
        {
            _dbSet.AddRange(entities);
            if (save) SaveChanges();
        }

        public virtual void UpdateRange(IEnumerable<TEntity> entities, bool save = true)
        {

            if (save)
                SaveChanges();
        }



        public virtual void DeleteRange(IEnumerable<TEntity> entities, bool save = true)
        {
            _dbSet.RemoveRange(entities);
            if (save)
                SaveChanges();
        }

        public virtual IQueryable<TEntity> Queryable()
        {
            return _dbSet;
        }


        public virtual void Clear()
        {

        }

        public virtual IRepository<T> GetRepository<T>() where T : class
        {
            return _unitOfWork.GetRepository<T>();
        }
    }
}