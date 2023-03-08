namespace MovieLibrary.Models.Movies
{
    public class MovieDetailsVM
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Released { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public Decimal Price { get; set; }
    }
}
