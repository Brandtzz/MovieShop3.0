using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieShopGateway.Services;

namespace MovieShopGateway
{
    class Facade
    {
        public MovieGatewayService getMovieGateway()
        {
            return new MovieGatewayService();
        }
    }
}
