using OnlineStore.AppServices.Common;
using System.Data;
using Npgsql;
using Microsoft.Extensions.Configuration;
using Dapper;

namespace OnlineStore.DataAccess.Common
{
    public abstract class DapperRepositoryBase<T> : IRepository<T> where T : class
    {
        private readonly IDbConnection _connection;

        protected DapperRepositoryBase(IConfiguration configuration)
        {
            _connection = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        public Task AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(int id)
        {
            return _connection.QuerySingleOrDefaultAsync<T>($"SELECT * FROM {typeof(T).Name}s where id = {id}");
        }
    }
}
