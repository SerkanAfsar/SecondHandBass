using SecondHandBass.Core.Abstract;

namespace SecondHandBass.Core.Models
{
    public class ConversationMessage : BaseEntity, IAuditable
    {
        public DateTime? CreatedOn { get; set; }
        public string? CreatedById { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string? UpdatedById { get; set; }
        public string SenderId { get; set; }
        public string Message { get; set; }
        public int ConversationId { get; set; }
        public Conversation Conversation { get; set; }

    }
}
