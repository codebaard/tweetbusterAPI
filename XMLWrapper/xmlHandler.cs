using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//my stuff
using System.Xml;
using System.Xml.Serialization;
using DatabaseWrapper;
using System.IO;

namespace XMLWrapper
{
    public class xmlHandler : databaseAPI
    {
        FileStream stream;

        public string path
        {
            get;
            set;
        }

        public xmlHandler()
        {
            path = "";
            //path = "D:\\_GameEngines\\tweetbusterAPI\\XMLWrapper\\database.xml";
            stream = null;
        }

        void initStream()
        {
            try
            {
                stream = new FileStream(path, FileMode.OpenOrCreate);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        public override void retrieveTweetsFromSource()
        {

            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Tweet>));
                this.Tweets = xmlSerializer.Deserialize(stream) as List<Tweet>;
                stream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }


        }
    }
}
