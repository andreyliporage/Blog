using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RolesScreen
{
  public class DeleteRoleScreen
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
      MenuRoleScreen.Load();
    }

    private static void Delete(int id)
    {
      try
      {
        var repository = new Repository<Role>(Database.Connection);
        repository.Delete(id);
        Console.WriteLine("Role excluída com sucesso!");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível exluir a role");
        Console.WriteLine(ex.Message);
      }
    }
  }
}