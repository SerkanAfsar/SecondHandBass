using SecondHandBass.Core.Models;
using SecondHandBass.Core.Repositories;
using SecondHandBass.DataAccessLayer.DataContexts;

namespace SecondHandBass.DataAccessLayer.Repositories
{
    public class AdvertisementPictureRepository : GenericRepository<AdvertisementPicture>, IAdvertisementPictureRepository
    {
        public AdvertisementPictureRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
