using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Screens.RolesScreen
{
    public class MenuRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Roles");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Roles");
            Console.WriteLine("2 - Cadastrar Role");
            Console.WriteLine("3 - Atualizar Role");
            Console.WriteLine("4 - Excluir Role");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListRoleScreen.Load();
                    break;
                case 2:
                    CreateRoleScreen.Load();
                    break;
                case 3:
                    UpdateRoleScreen.Load();
                    break;
                case 4:
                    DeleteRoleScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}