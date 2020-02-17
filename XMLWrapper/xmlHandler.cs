using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//my stuff
using System.Xml;
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
            using (XmlReader reader = XmlReader.Create(stream))
            {
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            Console.WriteLine("Start Element {0}", reader.Name);
                            break;
                        case XmlNodeType.Text:
                            Console.WriteLine("Text Node: {0}", reader.GetValue());
                            break;
                        case XmlNodeType.EndElement:
                            Console.WriteLine("End Element {0}", reader.Name);
                            break;
                        default:
                            Console.WriteLine("Other node {0} with value {1}",
                                            reader.NodeType, reader.Value);
                            break;
                    }
                }
            }

            return null;
        }



    }
}
