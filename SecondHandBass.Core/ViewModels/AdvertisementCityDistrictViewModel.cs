using SecondHandBass.Core.Abstract;
using SecondHandBass.Core.Models;

namespace SecondHandBass.Core.ViewModels
{
    public class AdvertisementCityDistrictViewModel : BaseEntity
    {
        public int AdvertisementId { get; set; }
        public Advertisement Advertisement { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int DistrictId { get; set; }
        public District District { get; set; }
    }
}
