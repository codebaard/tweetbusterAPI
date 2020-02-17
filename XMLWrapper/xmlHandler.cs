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
        string path; 

        public xmlHandler()
        {
            path = "D:\\_GameEngines\\tweetbusterAPI\\XMLWrapper\\database.xml";
            stream = new FileStream(path, FileMode.Open);
        }

        public override List<Tweet> retrieveTweetsFromSource()
        {
            List<Tweet> temp;

            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Tweet>));
                FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
                temp = xmlSerializer.Deserialize(stream) as List<Tweet>;
                stream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

            return temp;
        }

        //public void createXML()
        //{
        //    Tweets.Add(new Tweet(0, Topics.Xenophobia, "some random content", "picture.jpg"));
        //    string path = "sample.xml";

        //    XmlSerializer serial = new XmlSerializer(typeof(List<Tweet>));
        //    FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
        //    serial.Serialize(stream, Tweets);
        //    stream.Close();
        //}



    }
}
