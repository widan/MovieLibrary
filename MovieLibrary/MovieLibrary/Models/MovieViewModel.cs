using System.ComponentModel.DataAnnotations;

namespace MovieLibrary.Models
{
    public class MovieViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        public DateTime Released { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }

        [DisplayFormat()]
        public Decimal Price { get; set; }
    }
}
