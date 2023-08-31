using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

using var context = new BlogDataContext();

// var user = new User() 
// {
//     Name = "Andrey Liporage de Matos",
//     Bio = "Desenvolvedor FullStack",
//     Email = "andreydev.io@gmail.com",
//     Image = "google.com",
//     PasswordHash = "a1b2c3d4e5f6",
//     Slug = "andlmat"
// };

// var category = new Category() { Name = "Banckend", Slug = "backend" };

// var post = new Post()
// {
//     Author = user,
//     Category = category,
//     Body = "<p>Hello World</p>",
//     Slug = "comecando-com-ef-core",
//     Summary = "Aprendendo EF Core",
//     Title = "Començando com EF Core",
//     CreateDate = DateTime.Now,
//     LastUpdateDate = DateTime.Now
// };

// context.Posts.Add(post);
// context.SaveChanges();

var posts = context
            .Posts
            .AsNoTracking()
            .Include(x => x.Author)// faz JOIN com a tabela User
            //x.Author.Id faz um INNER JOIN na tabela de USER
            //.Where(x => x.Author.Id == 3)
            //x.AuthorId NÃO FAZ o INNER JOIN (ganho de performance)
            //.Where(x => x.AuthorId == 3)
            .OrderByDescending(x => x.LastUpdateDate)
            .ToList();
foreach (var post in posts)
    Console.WriteLine($"{post.Title} escrito por {post.Author?.Name}");