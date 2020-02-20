using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//my stuff
using System.Xml;
using System.Xml.Serialization;
using DatabaseWrapper;
using System.IO;
using UnityEngine;

namespace XMLWrapper
{
    public class xmlHandler : databaseAPI
    {
        private xmlHandler instance;

        public string path
        {
            get;
            set;
        }


        public xmlHandler(string path = "")
        {

            this.path = path;

            //stream = null;
        }



        public void initStream()
        {
            try
            {
                //stream = new FileStream(path, FileMode.OpenOrCreate);
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
                var xml = new XmlSerializer(typeof(List<Tweet>));
                TextAsset tAsset = Resources.Load("database") as TextAsset;
                using (var stream = new StringReader(tAsset.text))
                {
                    this.Tweets = xml.Deserialize(stream) as List<Tweet>;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

        }
    }
}
