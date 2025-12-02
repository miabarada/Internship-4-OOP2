namespace Internship_4_OOP2.Domain.Persistence.Common
{
    public interface IUnitOfWork
    {
        Task CreateTransaction();
        Task Commit();
        Task Rollback();
        Task SaveAsync();
    }
}
