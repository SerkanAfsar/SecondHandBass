using SecondHandBass.Core.Models;
using SecondHandBass.Core.Repositories;
using SecondHandBass.DataAccessLayer.DataContexts;

namespace SecondHandBass.DataAccessLayer.Repositories
{
    public class DistrictRepository : GenericRepository<District>, IDistrictRepository
    {
        public DistrictRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
