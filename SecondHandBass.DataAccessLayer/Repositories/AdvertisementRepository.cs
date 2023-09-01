using SecondHandBass.Core.Models;
using SecondHandBass.Core.Repositories;
using SecondHandBass.DataAccessLayer.DataContexts;

namespace SecondHandBass.DataAccessLayer.Repositories
{
    public class AdvertisementRepository : GenericRepository<Advertisement>, IAdvertisementRepository
    {
        public AdvertisementRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
