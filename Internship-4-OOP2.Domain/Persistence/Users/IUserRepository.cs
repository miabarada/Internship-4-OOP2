using Internship_4_OOP2.Domain.Entities.Users;
using Internship_4_OOP2.Domain.Persistence.Common;

namespace Internship_4_OOP2.Domain.Persistence.Users
{
    public interface IUserRepository : IRepository<User, int>
    {
        Task InsertAsync(User user);
    }
}
