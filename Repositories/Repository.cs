using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class Repository<T> where T : class
    {
        public readonly SqlConnection _connection;

        public Repository(SqlConnection connection)
            => _connection = Database.Connection;

        public IEnumerable<T> Get()
            => _connection.GetAll<T>();

        public T Get(int id)
         => _connection.Get<T>(id);

        public void Insert(T model)
         => _connection.Insert(model);
        
        public void Update(T model)
         => _connection.Update(model);

        public void Delete(T model) 
         => _connection.Delete<T>(model);

        public void Delete(int id)
        {
            var model = _connection.Get<T>(id);
            _connection.Delete<T>(model);
        }
    }
}