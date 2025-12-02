using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_4_OOP.Infrastructure
{
    public interface IDapperManager
    {
        Task<IReadOnlyList<T>> QueryAsync<T>(string sql, object? paran = null);
        Task<T?> QuerySingleAsync<T>(string sql, object? paran = null);
        Task ExecuteAsync(string sql, object? paran = null);
    }
}
