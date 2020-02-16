using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace apiDev
{
    class Program
    {
        static void Main(string[] args)
        {
            //twitterHandler.callTwitter().Wait();
            twitterHandler.initAPI().Wait();
        }
    }
}
