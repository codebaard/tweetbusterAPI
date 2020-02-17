using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseWrapper
{
    public abstract class databaseAPI
    {
        //List which containts the tweets
        protected List<Tweet> Tweets;
        protected static Random rand;

        //get random tweet
        public virtual Tweet getTweet()
        {
            return Tweets[rand.Next(Tweets.Count)];
        }

        //get tweet with ID from List
        public virtual Tweet getTweet(int ID)
        {
            foreach (Tweet tweet in Tweets){
                if (tweet.ID == ID) return tweet;
            }

            return null;
        }

        //get random tweet with topic
        public virtual Tweet getTweet(Topics topic)
        {
            List<Tweet> temp = new List<Tweet>();

            foreach (Tweet tweet in Tweets)
            {
                if (tweet.Topic == topic) temp.Add(tweet);
            }

            if (temp.Count == 0) return null;
            else return temp[rand.Next(temp.Count)];
        }

        //get tweets with topic XY
        public virtual List<Tweet> getTweetsWithTopic(Topics topic)
        {
            List<Tweet> temp = new List<Tweet>();

            foreach (Tweet tweet in Tweets)
            {
                if (tweet.Topic == topic) temp.Add(tweet);
            }

            if (temp.Count == 0) return null;
            else return temp;
        }

        //retrieve Tweets
        public abstract List<Tweet> retrieveTweetsFromSource();

    }

    public class Tweet
    {
        public int ID;
        public Topics Topic;
        public String Content;
        public String ProfilePicturePath;

        Tweet(int ID, Topics topic, String content, String ProfilePicturePath)
        {
            this.ID = ID;
            this.Topic = topic;
            this.Content = content;
            this.ProfilePicturePath = ProfilePicturePath;
        }
    }

    public enum Topics
    {
        Xenophobia,
        ClimateChange,
        Antivaccination,
        Flatearth,
        Chemtrails
    }
}
