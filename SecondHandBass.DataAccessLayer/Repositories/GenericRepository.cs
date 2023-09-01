using Microsoft.EntityFrameworkCore;
using SecondHandBass.Core.Abstract;
using SecondHandBass.Core.Repositories;
using SecondHandBass.DataAccessLayer.DataContexts;
using System.Linq.Expressions;

namespace SecondHandBass.DataAccessLayer.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly AppDbContext appDbContext;
        private readonly DbSet<TEntity> dbSet;
        public GenericRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
            this.dbSet = appDbContext.Set<TEntity>();
        }
        public async Task<TEntity> AddEntity(TEntity entity, CancellationToken cancellationToken = default)
        {
            await this.dbSet.AddAsync(entity, cancellationToken);
            return entity;
        }

        public async Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
        {
            await Task.Run(() => this.dbSet.RemoveRange(entities), cancellationToken);
            return entities;
        }

        public async Task<TEntity?> DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            var entity = await this.dbSet.FindAsync(id, cancellationToken);

            if (entity != null)
            {
                await Task.Run(() => this.dbSet.Remove(entity), cancellationToken);
            }

            return entity ?? null;
        }

        public async Task<IQueryable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, CancellationToken cancellationToken = default)
        {
            var result = this.dbSet.AsQueryable();
            if (predicate != null)
            {
                result = result.Where(predicate);
            }

            return await Task.Run(() => result, cancellationToken);
        }

        public async Task<TEntity?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await this.dbSet.FindAsync(id, cancellationToken) ?? null;
        }

        public async Task<IEnumerable<TEntity>> RemoveRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
        {
            await Task.Run(() => this.dbSet.RemoveRange(entities), cancellationToken);
            return entities;
        }

        public async Task<TEntity?> UpdateAsync(int id, TEntity entity, CancellationToken cancellationToken = default)
        {
            var existedEntity = await this.dbSet.FindAsync(id);

            if (existedEntity != null)
            {
                entity.Id = id;
                await Task.Run(() => appDbContext.Entry(existedEntity).CurrentValues.SetValues(entity), cancellationToken);
            }

            return existedEntity != null ? entity : null;
        }
    }
}
