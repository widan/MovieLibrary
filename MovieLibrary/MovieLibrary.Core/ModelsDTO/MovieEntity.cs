using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Core.ModelsDTO
{
    [Table("Movies")]
    public class MovieEntity
    {
        private DateTime _updatedMovieInLibraryDate;
        private DateTime _addedToLibraryDate;
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime Released { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public Decimal Price { get; set; }
        
        public DateTime AddedToLibraryDate {
            get
            {
                return _addedToLibraryDate;
            }
            set
            {
                if(_addedToLibraryDate == new DateTime())
                {
                    _addedToLibraryDate = DateTime.Now;
                }
            }
        }
        public DateTime UpdatedMovieInLibraryDate { 
            get
            {
                return _updatedMovieInLibraryDate;
            }
            set
            {
                _updatedMovieInLibraryDate = DateTime.Now;
            }
        }

        public List <MovieGenresEntity> MovieGenresEntities { get; set; }
    }
}
