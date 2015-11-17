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
                    client.GetAsync("http://localhost:17883/api/Order/").Result;
                return response.Content.ReadAsAsync<IEnumerable<Order>>().Result;
            }
        }

        public Order Add(Order order)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("http://localhost:17883/api/Order/", order).Result;
                return response.Content.ReadAsAsync<Order>().Result;
            }
        }

        public Order Delete(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.DeleteAsync("http://localhost:17883/api/Order/" + id.ToString()).Result;
                return response.Content.ReadAsAsync<Order>().Result;
            }
        }

        public Order Update(Order order)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.PostAsJsonAsync("http://localhost:17883/api/Order/", order.Id).Result;
                return response.Content.ReadAsAsync<Order>().Result;
            }
        }

        public Order Read(int id)
        {
            using (var Client = new HttpClient())
            {
                HttpResponseMessage response =
                    Client.GetAsync("http://localhost:17883/api/Order/" + id.ToString()).Result;
                return response.Content.ReadAsAsync<Order>().Result;
            }
        }
    }
}

