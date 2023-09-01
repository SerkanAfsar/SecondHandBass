using SecondHandBass.Core.Abstract;

namespace SecondHandBass.Core.Models
{
    public class Conversation : BaseEntity
    {
        public int AdvertasementId { get; set; }
        public Advertisement Advertisement { get; set; }
        public string SenderId { get; set; }
        public string RecieverId { get; set; }
        public List<ConversationMessage> Messages { get; set; } = new List<ConversationMessage>();
    }
}
