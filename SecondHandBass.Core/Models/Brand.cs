using SecondHandBass.Core.Abstract;

namespace SecondHandBass.Core.Models
{
    public class Brand : BaseEntity, IAuditable, IQueue
    {
        public DateTime? CreatedOn { get; set; }
        public string? CreatedById { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string? UpdatedById { get; set; }
        public string BrandName { get; set; }
        public int? Queue { get; set; }
        public List<Model> Models { get; set; } = new List<Model>();
        public List<Advertisement> Advertisements { get; set; } = new List<Advertisement>();

    }
}
