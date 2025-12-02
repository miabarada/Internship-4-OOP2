using Dapper;
using Npgsql;

namespace Internship_4_OOP.Infrastructure
{
    internal class DapperManager : IDapperManager
    {
        private readonly string _connectionString;

        public DapperManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DapperManager()
        {
        }

        private NpgsqlConnection CreateConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }

        public async Task ExecuteAsync(string sql, object? paran = null)
        {
            using var connection = CreateConnection();
            await connection.OpenAsync();

            await connection.ExecuteAsync(sql, paran);
        }

        public async Task<IReadOnlyList<T>> QueryAsync<T>(string sql, object? paran = null)
        {
            using var connection = CreateConnection();
            await connection.OpenAsync();

            var result = await connection.QueryAsync<T>(sql, paran);
            return result.AsList();
        }

        public async Task<T?> QuerySingleAsync<T>(string sql, object? paran = null)
        {
            using var connection = CreateConnection();
            await connection.OpenAsync();

            return await connection.QuerySingleOrDefaultAsync<T>(sql, paran);
        }
    }
}
