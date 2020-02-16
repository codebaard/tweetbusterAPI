using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//my stuff
using System.Net.Http;
using System.Net.Http.Headers;
namespace apiDev
{
    class twitterAPI
    {
        private static HttpClient client;

        public twitterAPI()
        {
            client = new HttpClient();

            client.BaseAddress = new Uri("https://api.twitter.com/1.1/tweets/search/30day/Tweetbuster2.json");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "");

        }

        public static async Task apiCall()
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, client.BaseAddress);
            request.Content = new StringContent("some JSON stuff");
            try
            {
                HttpResponseMessage response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                Console.WriteLine(responseBody);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        
    }
}
