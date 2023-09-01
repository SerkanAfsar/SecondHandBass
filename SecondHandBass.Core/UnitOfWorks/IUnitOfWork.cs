namespace SecondHandBass.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
