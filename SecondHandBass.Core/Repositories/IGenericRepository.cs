using SecondHandBass.Core.Abstract;
using System.Linq.Expressions;

namespace SecondHandBass.Core.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        Task<IQueryable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, CancellationToken cancellationToken = default);

        Task<TEntity> AddEntity(TEntity entity, CancellationToken cancellationToken = default);
        Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);
        Task<TEntity?> UpdateAsync(int id, TEntity entity, CancellationToken cancellationToken = default);
        Task<TEntity?> DeleteAsync(int id, CancellationToken cancellationToken = default);
        Task<IEnumerable<TEntity>> RemoveRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);
    }
}
