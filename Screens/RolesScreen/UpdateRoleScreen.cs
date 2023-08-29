using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RolesScreen
{
    public class UpdateRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando uma role");
            Console.WriteLine("-------------");
            Console.Write("Id: ");
            var id = Console.ReadLine();

            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Update(new Role { Name = name, Slug = slug });
            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        private static void Update(Role role)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection);
                repository.Update(role);
                Console.WriteLine("Role atualizada com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar a role");
                Console.WriteLine(ex.Message);
            }
        }
    }
}