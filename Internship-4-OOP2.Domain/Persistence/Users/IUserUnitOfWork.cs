namespace Internship_4_OOP2.Domain.Persistence.Users
{
    public interface IUserUnitOfWork
    {
        IUserRepository Repository { get; }
    }
}
