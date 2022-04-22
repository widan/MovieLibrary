using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Infrastructure.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime Released { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }

        [DataType(DataType.Currency)]
        public Decimal Price { get; set; }
    }
}
