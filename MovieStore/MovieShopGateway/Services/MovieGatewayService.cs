using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MovieStoreDAL;

namespace MovieShopGateway.Services
{
    public class MovieGatewayService
    {
        public IEnumerable<Movie> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = 
                    client.GetAsync("http://localhost:9885/api/Movie/").Result;
                return response.Content.ReadAsAsync<IEnumerable<Movie>>().Result;
            }
        }

        public Movie Add(Movie movie)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("http://localhost:9885/api/Movie/", movie).Result;
                return response.Content.ReadAsAsync<Movie>().Result;
            }
        }

        public Movie Delete(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.DeleteAsync("http://localhost:9885/api/Movie/" + id.ToString()).Result;
                return response.Content.ReadAsAsync<Movie>().Result;
            }
        }

        public Movie Update(Movie movie)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.PostAsJsonAsync("http://localhost:9885/api/Movie/", movie.Id).Result;
                return response.Content.ReadAsAsync<Movie>().Result;
            }
        }

        public Movie Read(int id)
        {
            using (var Client = new HttpClient())
            {
                HttpResponseMessage response =
                    Client.GetAsync("http://localhost:9885/api/Movie/" + id.ToString()).Result;
                return response.Content.ReadAsAsync<Movie>().Result;
            }
        }
    }
}
