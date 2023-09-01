using SecondHandBass.Core.Abstract;

namespace SecondHandBass.Core.Models
{
    public class Model : BaseEntity, IAuditable, IQueue
    {
        public DateTime? CreatedOn { get; set; }
        public string? CreatedById { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string? UpdatedById { get; set; }
        public string ModelName { get; set; }
        public int? Queue { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public List<Advertisement> Advertisements { get; set; } = new List<Advertisement>();
    }
}
