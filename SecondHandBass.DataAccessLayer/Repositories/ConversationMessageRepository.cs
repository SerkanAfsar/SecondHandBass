using SecondHandBass.Core.Models;
using SecondHandBass.Core.Repositories;
using SecondHandBass.DataAccessLayer.DataContexts;

namespace SecondHandBass.DataAccessLayer.Repositories
{
    public class ConversationMessageRepository : GenericRepository<ConversationMessage>, IConversationMessageRepository
    {
        public ConversationMessageRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
