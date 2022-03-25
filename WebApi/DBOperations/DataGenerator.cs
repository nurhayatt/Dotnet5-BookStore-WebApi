using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
namespace WebApi.DBOperations
{
    public class DataGenrator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>())) ;
            {
                if (context.Books.Any())
                {
                    return;
                }
                context.Books.AddRange(
            new Book() { Id = 1, Title = "Book 1", GenreId = 1, Page = 100, PublishDate = DateTime.Now },
            new Book() { Id = 2, Title = "Book 2", GenreId = 2, Page = 200, PublishDate = DateTime.Now },
            new Book() { Id = 3, Title = "Book 3", GenreId = 3, Page = 300, PublishDate = DateTime.Now }
            );

            }
            context.SaveChanges();
        }
    }
}