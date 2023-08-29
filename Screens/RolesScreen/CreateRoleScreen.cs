using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RolesScreen
{
    public class CreateRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova Role");
            Console.WriteLine("-------------");
            Console.WriteLine("Nome: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Create(new Role { Name = nome, Slug = slug });

            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        private static void Create(Role role)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection);
                repository.Insert(role);
                Console.WriteLine("Role cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível cadastrar a role");
                Console.WriteLine(ex.Message);
            }
        }
    }
}