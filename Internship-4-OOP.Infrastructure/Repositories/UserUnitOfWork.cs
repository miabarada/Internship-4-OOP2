using Internship_4_OOP.Infrastructure.Database;
using Internship_4_OOP2.Domain.Persistence.Users;

namespace Internship_4_OOP.Infrastructure.Repositories
{
    internal class UserUnitOfWork : IUserUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;
        public IUserRepository Repository {  get; set; }

        public UserUnitOfWork(ApplicationDbContext dbContext, IUserRepository repository)
        {
            _dbContext = dbContext;
            Repository = repository;
        }

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
