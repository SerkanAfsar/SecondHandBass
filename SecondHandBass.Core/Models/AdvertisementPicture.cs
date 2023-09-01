using SecondHandBass.Core.Abstract;

namespace SecondHandBass.Core.Models
{
    public class AdvertisementPicture : BaseEntity, IAuditable, IQueue
    {
        public DateTime? CreatedOn { get; set; }
        public string? CreatedById { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string? UpdatedById { get; set; }
        public string? PictureSmall { get; set; }
        public string? PictureMedium { get; set; }
        public string? PictureBig { get; set; }
        public int? Queue { get; set; }
        public int AdvetisementId { get; set; }
        public Advertisement Advetisement { get; set; }
    }
}
