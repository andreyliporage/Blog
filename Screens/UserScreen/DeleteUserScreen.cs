using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreen
{
    public class DeleteUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir uma tag");
            Console.WriteLine("-------------");
            Console.Write("Qual o id da Tag que deseja exluir? ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        private static void Delete(int id)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Usuário excluído com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível exluir o usuário");
                Console.WriteLine(ex.Message);
            }
        }
    }
}