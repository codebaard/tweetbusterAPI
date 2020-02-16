using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiDev
{
    public class jsonObjects
    {

        public jsonObjects()
        {
            Query = new query("from:TwitterDev lang:en");
            MaxResults = new maxResults("100");
            FromDate = new fromDate("202001010000");
            ToDate = new toDate("202001312359");
        }

        public query Query;
        public maxResults MaxResults;
        public fromDate FromDate;
        public toDate ToDate;

    }

    public class query
    {
        public query(string value)
        {
            type = value;
        }
        public string type;
    }

    public class maxResults
    {
        public maxResults(string value)
        {
            max = value;
        }
        public string max;
    }

    public class fromDate
    {
        public fromDate(string value)
        {
            date = value;
        }
        public string date;
    }

    public class toDate
    {
        public toDate(string value)
        {
            date = value;
        }
        public string date;
    }
}
