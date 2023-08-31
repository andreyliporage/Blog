using Blog.Data;
using Blog.Models;

using var context = new BlogDataContext();

// var user = new User()
// {
//     Name = "Andrey Liporage",
//     Email = "andreydev.io@gmail.com",
//     Bio = "Desenvolvedor FullStack",
//     Image = "google.com",
//     PasswordHash = "a1b2c3e4f5g6",
//     Slug = "andlmat"
// };
// context.Users.Add(user);
// context.SaveChanges();

var user = context.Users.FirstOrDefault();
var post = new Post()
{
    Author = user,
    Body = "Melhorando a perfomance utilizando .NET 6, SQL Server e EntityFramework Core",
    Category = new Category{ Name = "Backend", Slug = "backend" },
    Title = "Desafio Rinha Backend",
    CreateDate = DateTime.Now.ToUniversalTime(),
    Tags = null,
    Summary = "Desafio",
    Slug = "Back"
};

context.Posts.Add(post);
context.SaveChanges();