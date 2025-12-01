using Internship_4_OOP2.Domain.Entities.Users;

namespace Internship_4_OOP2.Domain.Persistence.Users
{
    public interface IUserRepository
    {
        Task<User> GetById(int id);
    }
}
