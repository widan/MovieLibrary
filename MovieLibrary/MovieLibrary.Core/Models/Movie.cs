using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Core.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime Released { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }

    }
}
