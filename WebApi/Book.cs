namespace WebApi
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        public int GenreId { get; set; }

        public int Page { get; set; }

        public DateTime PublishDate { get; set; }
}
}