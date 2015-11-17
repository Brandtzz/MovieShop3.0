using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
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
                    client.GetAsync("http://localhost:17883/api/Customer/").Result;
                return response.Content.ReadAsAsync<IEnumerable<Customer>>().Result;
            }
        }

        public Customer Add(Customer customer)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("http://localhost:17883/api/Customer/", customer).Result;
                return response.Content.ReadAsAsync<Customer>().Result;
            }
        }

        public Customer Delete(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.DeleteAsync("http://localhost:17883/api/Customer/" + id.ToString()).Result;
                return response.Content.ReadAsAsync<Customer>().Result;
            }
        }

        public Customer Update(MovieStoreDAL.Customer customer)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.PostAsJsonAsync("http://localhost:17883/api/Customer/", customer.Id).Result;
                return response.Content.ReadAsAsync<Customer>().Result;
            }
        }

        public Customer Read(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync("http://localhost:17883/api/Customer/" + id.ToString()).Result;
                return response.Content.ReadAsAsync<Customer>().Result;
            }
        }
    }
}

