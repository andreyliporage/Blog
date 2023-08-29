using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Repositories;

namespace Blog.Screens.UserScreen
{
    public class ListUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Roles");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        private static void List()
        {
            var repository = new UserRepository(Database.Connection);
            var users = repository.GetUsers();

            foreach (var user in users)
            {
                Console.WriteLine(user.Name);
                foreach (var role in user.Roles) Console.WriteLine($" - {role.Slug}");
            }
        }
    }
}