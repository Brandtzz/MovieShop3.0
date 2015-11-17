using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MovieStoreDAL;
using MovieStoreDTO;

namespace MovieStoreRestApi.Controllers
{
    public class MovieController : ApiController
    {
        MovieConverter movieConverter = new MovieConverter();
        DALFacade dalFacade = new DALFacade();

        public IEnumerable<MovieDto> GetMovies()
        {
            var movies = dalFacade._moviesRepository.GetAll();
            return movieConverter.Convert(movies);
        }

        public MovieDto GetMovie(int id)
        {
            var movies = dalFacade._moviesRepository.Get(id);
            return movieConverter.Convert(movies);
        }

        public MovieDto PostMovie(MovieDto movieDto)
        {
            return movieDto;
        }

        public MovieDto PutMovie(Movie movie)
        {
            
            var movies = dalFacade._moviesRepository.Edit(movie);
            return movieConverter.Convert(movies);
        }

        public MovieDto DeleteMovie(int id)
        {
            var movies = dalFacade._moviesRepository.Remove(id);
            return movieConverter.Convert(movies);
        }
    }
}
