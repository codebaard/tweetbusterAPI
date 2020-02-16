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
            await twitterAPI.apiCall();
        }

        public static async Task initAPI()
        {
            //await twitterAPI.obtainBearerToken();
        }
    }
}
