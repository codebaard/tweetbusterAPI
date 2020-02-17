using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace XMLWrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            xmlHandler xml = new xmlHandler();

            xml.retrieveTweetsFromSource();
        }
    }
}
