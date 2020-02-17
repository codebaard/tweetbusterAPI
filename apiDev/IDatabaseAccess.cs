using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiDev
{
    interface IDatabaseAccess
    {
        String getTweet();

        String getPicture();

        void SetTopic();

        List<String> getTopics();
        






    }

    

    
}
