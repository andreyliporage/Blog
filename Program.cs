﻿using Blog;
using Blog.Models;
using Blog.Repositories;
using Blog.Screens.RolesScreen;
using Blog.Screens.UserRoleScreen;
using Blog.Screens.UserScreen;
using Microsoft.Data.SqlClient;

const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;";
Database.Connection = new SqlConnection(CONNECTION_STRING);

Database.Connection.Open();

Load();

Database.Connection.Close();

static void Load()
{
    Console.Clear();
    Console.WriteLine("Meu Blog");
    Console.WriteLine("-----------------");
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine();
    Console.WriteLine("1 - Gestão de usuário");
    Console.WriteLine("2 - Gestão de perfil");
    Console.WriteLine("3 - Gestão de categoria");
    Console.WriteLine("4 - Gestão de tag");
    Console.WriteLine("5 - Vincular perfil/usuário");
    Console.WriteLine("6 - Vincular post/tag");
    Console.WriteLine("7 - Relatórios");
    Console.WriteLine();
    Console.WriteLine();
    var option = short.Parse(Console.ReadLine()!);

    switch (option)
    {
        case 1:
            MenuUserScreen.Load();
            break;
        case 2:
            MenuRoleScreen.Load();
            break;
        case 5:
            VinculaUserRole.Load();
            break;
        default: Load(); break;
    }
}