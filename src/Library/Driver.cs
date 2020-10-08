using System;
using System.Collections;
using TwitterUCU;

namespace PII_Herencia
{
    public class Driver:IPerson
    {
        public string name{get;set;}
        public string sureName{get;set;}
        public string id{get;set;}
        public string biography{get;set;}
        public Classification classification{get;set;}
        public Driver(string name, string sureName, string id, string biography)
        {
            this.name = name;
            this.sureName = sureName;
            this.id = id;
            this.classification = Classification.Driver;
            this.biography = biography;
        }
        public void Public()
        {
            string consumerKey = "CkovShLMNVCY0STsZlcRUFu99";
            string consumerKeySecret = "6rc35cHCyqFQSy4vIIjKiCYu31qqkBBkSS5BRlqeYCt5r7zO5B";
            string accessTokenSecret = "gNytQjJgLvurJekVU0wmBBkrR1Th40sJmTO8JDhiyUkuy";
            string accessToken = "1396065818-MeBf8ybIXA3FpmldORfBMdmrVJLVgijAXJv3B18";
            var twitter = new TwitterImage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            Console.WriteLine(twitter.PublishToTwitter("Welcome " + this.name +" "+this.sureName+" to UcuRideShare! He is our new " + Classification.Driver.ToString(),@"bill2.jpg"));
            var twitterDirectMessage = new TwitterMessage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            Console.WriteLine(twitterDirectMessage.SendMessage("Welcome " + this.name +" "+this.sureName+" to UcuRideShare! You are our new " + Classification.Driver.ToString(), "1396065818"));
        }
    }
}
