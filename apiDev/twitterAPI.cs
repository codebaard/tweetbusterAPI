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
        private static requestData requestData;


        private static void initTwitterAPI()
        {
            client = new HttpClient();

            //client.BaseAddress = new Uri("https://api.twitter.com/1.1/tweets/search/30day/Tweetbuster2.json");
            client.BaseAddress = new Uri("https://api.twitter.com/1.1/search/tweets.json");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "AAAAAAAAAAAAAAAAAAAAADFqAQEAAAAAJLtctixbH6iFXRW1p%2FdjTtB7Fmo%3DsO6UHVTdRblcv8rM78ydQvljK4oseEmpRqSjL0INSMijxpOtjk");

        }

        public static async Task apiCall()
        {
            if (client == null) initTwitterAPI();

            //requestBody = new requestData();
            using (requestData = new requestData())
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, client.BaseAddress);
                request.Content = new StringContent(requestData.createRequest(), Encoding.UTF8, "application/json");

                try
                {
                    HttpResponseMessage response = await client.SendAsync(request);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    Console.WriteLine(responseBody);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        
    }
}
