using SecondHandBass.Core.UnitOfWorks;
using SecondHandBass.DataAccessLayer.DataContexts;

namespace SecondHandBass.DataAccessLayer.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext appDbContext;
        public UnitOfWork(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public void SaveChanges(CancellationToken cancellationToken = default)
        {
            this.appDbContext.SaveChanges();
        }

        public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await this.appDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
