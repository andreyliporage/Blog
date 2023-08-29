using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreen
{
    public class UpdateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando um Usuário");
            Console.WriteLine("-------------");
            Console.Write("Id: ");
            var id = Console.ReadLine();

            Console.WriteLine("Nome: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Email: ");
            var email = Console.ReadLine();

            Console.WriteLine("Password: ");
            var password = Console.ReadLine();

            Console.WriteLine("Bio: ");
            var bio = Console.ReadLine();

            Console.WriteLine("Imagem: ");
            var imagem = Console.ReadLine();

            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Update(new User { Name = nome, Email = email, PasswordHash = password, Bio = bio, Image = imagem, Slug = slug });
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        private static void Update(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Update(user);
                Console.WriteLine("Usuário atualizado com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel atualizar o usuário");
                Console.WriteLine(ex.Message);
            }
        }
    }
}