using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RolesScreen
{
    public class ListRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Roles");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<Role>(Database.Connection);
            var roles = repository.Get();

            foreach (var role in roles)
            {
                Console.WriteLine($"{role.Id} - {role.Name} - {role.Slug}");
            }
        }
    }
}