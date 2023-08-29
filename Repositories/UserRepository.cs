using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.XPath;
using Blog.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class UserRepository : Repository<User>
    {
        private readonly SqlConnection _connection;
        public UserRepository(SqlConnection connection) : base(Database.Connection)
        {
            _connection = connection;
        }

        public List<User> GetUsers()
        {
            var query = @"
                SELECT 
                    [User].*,
                    [Role].*
                FROM
                    [User]
                LEFT JOIN [UserRole] ON [UserRole].[UserId] = [User].[Id]
                LEFT JOIN [Role] ON [UserRole].[RoleId] = [Role].[Id]";
            var users = new List<User>();
            var items = _connection.Query<User, Role, User>(query, (user, role) => {
                var usr = users.FirstOrDefault(x => x.Id == user.Id);
                if (usr is null)
                {
                    usr = user;
                    if (role is not null)
                    {
                        usr.AddRole(role);
                    }
                    users.Add(usr);
                }
                else
                {
                    usr.AddRole(role);
                }
                return user;
            }, splitOn: "Id");

            return users;
        }
    }
}