using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopGateway.Services
{
    public abstract class AbstractGateway
    {
        public HttpClient Client()
        {
            HttpClient client = new HttpClient();
            string baseAddress = "http://localhost:9885/api/Movie/";
            client.BaseAddress = new Uri(baseAddress);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }

    }
}
