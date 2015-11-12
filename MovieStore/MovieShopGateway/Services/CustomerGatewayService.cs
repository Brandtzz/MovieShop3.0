using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MovieStoreDAL;

namespace MovieShopGateway.Services
{
    public class CustomerGatewayService
    {
        public IEnumerable<CustomerGatewayService> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:4835/api/customer/").Result;
                return response.Content.ReadAsAsync<IEnumerable<CustomerGatewayService>>().Result;
            }
        }

        public CustomerGatewayService Add(CustomerGatewayService customer)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("http://localhost:4835/api/customer/", customer).Result;
                return response.Content.ReadAsAsync<CustomerGatewayService>().Result;
            }
        }

        public CustomerGatewayService Delete(CustomerGatewayService customer)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.DeleteAsync("http://localhost:4835/api/customer/").Result;
                return response.Content.ReadAsAsync<CustomerGatewayService>().Result;
            }
        }

        public CustomerGatewayService Update(CustomerGatewayService customer)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.PostAsJsonAsync("http://localhost:4835/api/customer/", customer).Result;
                return response.Content.ReadAsAsync<CustomerGatewayService>().Result;
            }
        }
    }
}

