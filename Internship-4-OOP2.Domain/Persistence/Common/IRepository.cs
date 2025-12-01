using Internship_4_OOP2.Domain.Common.Model;

namespace Internship_4_OOP2.Domain.Persistence.Common
{
    public interface IRepository<TEntity, Tid> where TEntity : class
    {
        Task<GetAllResponse<TEntity>> Get();
        Task InsertAsync(TEntity entity);
        void Update(TEntity entity);
        Task DeleteAsync(Tid id);
        void Delete(TEntity entity);
    }
}
