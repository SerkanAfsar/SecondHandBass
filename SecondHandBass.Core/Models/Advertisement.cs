using SecondHandBass.Core.Abstract;
using SecondHandBass.Core.ViewModels;

namespace SecondHandBass.Core.Models
{
    public class Advertisement : BaseEntity, IAuditable
    {
        public DateTime? CreatedOn { get; set; }
        public string? CreatedById { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string? UpdatedById { get; set; }
        public string Title { get; set; }
        public string? Explanation { get; set; }
        public string UserId { get; set; }
        public AppUser AppUser { get; set; }
        public int AdvertisementCityDiscrictViewModelId { get; set; }
        public AdvertisementCityDistrictViewModel AdvertisementCityDistrict { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public decimal? Price { get; set; }
        public List<AdvertisementPicture> AdvertisementPictures { get; set; } = new List<AdvertisementPicture>();

    }
}
