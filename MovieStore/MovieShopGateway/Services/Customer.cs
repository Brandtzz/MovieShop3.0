using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MovieStoreDAL;

namespace MovieShopGateway.Services
{
    public class Customer
    {
        public IEnumerable<Customer> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:4835/api/movie/").Result;
                return response.Content.ReadAsAsync<IEnumerable<Customer>>().Result;
            }
        }

        public Customer Add(Customer customer)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("http://localhost:4835/api/movie/", customer).Result;
                return response.Content.ReadAsAsync<Customer>().Result;
            }
        }

        public Customer Delete(Customer customer)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.DeleteAsync("http://localhost:4835/api/movie/").Result;
                return response.Content.ReadAsAsync<Customer>().Result;
            }
        }

        public Customer Update(Customer customer)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.PostAsJsonAsync("http://localhost:4835/api/movie/", movie).Result;
                return response.Content.ReadAsAsync<Customer>().Result;
            }
        }
    }
}
}
