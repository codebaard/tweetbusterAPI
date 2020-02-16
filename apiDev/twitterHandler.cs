using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiDev
{
    class twitterHandler
    {
        public static async Task callTwitter()
        {
            await twitterAPI.apiCall("https://api.twitter.com/1.1/tweets/search/30day/Tweetbuster2.json");
        }

        public static async Task initAPI()
        {
            await twitterAPI.obtainBearerToken();
        }
    }
}
