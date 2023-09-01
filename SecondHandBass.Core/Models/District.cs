using SecondHandBass.Core.Abstract;

namespace SecondHandBass.Core.Models
{
    public class District : BaseEntity, IAuditable, IQueue
    {
        public DateTime? CreatedOn { get; set; }
        public string? CreatedById { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string? UpdatedById { get; set; }
        public string CityName { get; set; }
        public int? Queue { get; set; }
        public string DistrictName { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
