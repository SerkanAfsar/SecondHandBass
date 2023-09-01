namespace SecondHandBass.Core.Abstract
{
    public interface IAuditable
    {
        public DateTime? CreatedOn { get; set; }
        public string? CreatedById { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string? UpdatedById { get; set; }
    }
}
