using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieShopGateway.Services;

namespace MovieShopGateway
{
   public class Facade
    {
        public MovieGatewayService GetMovieGatewayService()
        {
            return new MovieGatewayService();
        }

        public Customer GetCustomerGatewayService()
        {
            return new Customer();
        }

        public OrderGatewayService GetOrderGatewayService()
        {
            return new OrderGatewayService();
        }
    }

}
