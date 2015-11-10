using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MovieStoreDAL;

namespace MovieShopGateway.Services
{
    public class OrderGatewayService
    {
        public IEnumerable<Order> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:4835/api/movie/").Result;
                return response.Content.ReadAsAsync<IEnumerable<Order>>().Result;
            }
        }

        public Order Add(Order order)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("http://localhost:4835/api/movie/", order).Result;
                return response.Content.ReadAsAsync<Order>().Result;
            }
        }

        public Order Delete(Order order)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.DeleteAsync("http://localhost:4835/api/movie/").Result;
                return response.Content.ReadAsAsync<Order>().Result;
            }
        }

        public Order Update(Order order)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.PostAsJsonAsync("http://localhost:4835/api/movie/", order).Result;
                return response.Content.ReadAsAsync<Order>().Result;
            }
        }
    }
}

