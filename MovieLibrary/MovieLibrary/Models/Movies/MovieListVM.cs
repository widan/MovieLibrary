namespace MovieLibrary.Models.Movies
{
    public class MovieListVM
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public Decimal Price { get; set; }
    }
}
