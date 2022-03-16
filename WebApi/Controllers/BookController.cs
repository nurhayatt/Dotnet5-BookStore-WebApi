using Microsoft.AspNetCore.Mvc;

namespace WebApi.AddControllers
{
    [ApiController]
    [Route("[controller]s")]
    public class BookContoller : ControllerBase
    {
        private static List<Book> BookList = new List<Book>()
     {
            new Book() { Id = 1, Title = "Book 1", GenreId = 1, Page = 100, PublishDate = DateTime.Now },
            new Book() { Id = 2, Title = "Book 2", GenreId = 2, Page = 200, PublishDate = DateTime.Now },
            new Book() { Id = 3, Title = "Book 3", GenreId = 3, Page = 300, PublishDate = DateTime.Now },
            new Book() { Id = 4, Title = "Book 4", GenreId = 4, Page = 400, PublishDate = DateTime.Now },
            new Book() { Id = 5, Title = "Book 5", GenreId = 5, Page = 500, PublishDate = DateTime.Now },
            new Book() { Id = 6, Title = "Book 6", GenreId = 6, Page = 600, PublishDate = DateTime.Now },
            new Book() { Id = 7, Title = "Book 7", GenreId = 7, Page = 700, PublishDate = DateTime.Now },
            new Book() { Id = 8, Title = "Book 8", GenreId = 8, Page = 800, PublishDate = DateTime.Now },
            new Book() { Id = 9, Title = "Book 9", GenreId = 9, Page = 900, PublishDate = DateTime.Now },
            new Book() { Id = 10, Title = "Book 10", GenreId = 10, Page = 1000, PublishDate = DateTime.Now },
            new Book() { Id = 11, Title = "Book 11", GenreId = 11, Page = 1100, PublishDate = DateTime.Now },
            new Book() { Id = 12, Title = "Book 12", GenreId = 12, Page = 1200, PublishDate = DateTime.Now },
            new Book() { Id = 13, Title = "Book 13", GenreId = 13, Page = 1300, PublishDate = DateTime.Now },
            new Book() { Id = 14, Title = "Book 14", GenreId = 14, Page = 1400, PublishDate = DateTime.Now },

    };
        [HttpGet]
        public List<Book> GetBooks()
        {
            var bookList = BookList.OrderBy(x => x.Id).ToList<Book>();
            return bookList;
        }

        [HttpGet("{id}")]
        public Book GetById(int id)
        {
            var book = BookList.Where(x => x.Id == id).SingleOrDefault();
            return book;
        }
      
        
        


    }
}