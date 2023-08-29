using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class UserRoleRepository : Repository<UserRole>
    {
        private readonly SqlConnection _connection;

        public UserRoleRepository(SqlConnection connection) : base(connection)
        {
            _connection = connection;
        }

        public void CreateUserRole(int userId, int roleId)
        {
            var sql = @"
                INSERT INTO [UserRole]
                VALUES (@UserId, @RoleId)";

            _connection.Execute(sql, new { userId, roleId });
        }
    }
}