using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;
using Blog.Screens.UserScreen;

namespace Blog.Screens.UserRoleScreen
{
    public class VinculaUserRole
    {

        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Vincular perfil");
            Console.WriteLine("-------------");

            Console.WriteLine("Id do Usuário: ");
            var userId = int.Parse(Console.ReadLine());

            Console.WriteLine("Id do Perfil: ");
            var roleId = int.Parse(Console.ReadLine());

            Create(userId, roleId);

            Console.ReadKey();
            MenuUserScreen.Load();
        }   

        private static void Create(int userId, int roleId)
        {
            try
            {
                var repository = new UserRoleRepository(Database.Connection);
                repository.CreateUserRole(userId, roleId);
                Console.WriteLine("Perfil vinculado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao vincular perfil");
                Console.WriteLine(ex.Message);
            }
        }
    }
}