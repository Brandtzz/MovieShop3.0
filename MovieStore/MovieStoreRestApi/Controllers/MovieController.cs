using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MovieStoreDAL;

namespace MovieStoreRestApi.Controllers
{
    public class MovieController : ApiController
    {
        
        DALFacade dalFacade = new DALFacade();

        public IEnumerable<> GetMovies()
        {
            var movies = dalFacade._moviesRepository.GetAll();
            return new 
        }
    }
}
