using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using MovieStoreDAL;

namespace MovieStoreDTO
{
    public class MovieConverter : AbstractDTOConverter<Movie, MovieDto>
    {
        public override MovieDto Convert(Movie movie)
        {
            var dto = new MovieDto()
            {
                Id = movie.Id,
                Title = movie.Title,
                Price = movie.Price,
                Year = movie.Year,
                TrailerUrl = movie.TrailerUrl,
                ImageUrl = movie.ImageUrl,
                Genre = movie.Genre
            }
            ;
            return dto;
        }
    }
}





