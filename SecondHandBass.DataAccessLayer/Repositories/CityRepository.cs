using SecondHandBass.Core.Models;
using SecondHandBass.Core.Repositories;
using SecondHandBass.DataAccessLayer.DataContexts;

namespace SecondHandBass.DataAccessLayer.Repositories
{
    public class CityRepository : GenericRepository<City>, ICityRepository
    {
        public CityRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
