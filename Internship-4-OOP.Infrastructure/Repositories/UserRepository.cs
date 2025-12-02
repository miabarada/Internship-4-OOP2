using Internship_4_OOP.Infrastructure.Database;
using Internship_4_OOP2.Domain.Entities.Users;
using Internship_4_OOP2.Domain.Persistence.Users;
using Microsoft.EntityFrameworkCore;

namespace Internship_4_OOP.Infrastructure.Repositories
{
    public sealed class UserRepository : Repository<User, int>, IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IDapperManager _dapperManager;

        public UserRepository(DbContext dbContext, IDapperManager dapperManager) 
            : base(dbContext)
        {
            _dapperManager = dapperManager;
        }

        public async Task<User> GetById(int id)
        {
            var sql =
                """"
                SELECT
                    id AS Id
                    name AS Name
                    date_of_birth AS DateOfBirth
                FROM
                    public.users
                WHERE 
                    id = @id
                """";

            var parameters = new
            {
                Id = id
            };

            return await _dapperManager.QuerySingleAsync<User>(sql, parameters);
        }
    }
}
