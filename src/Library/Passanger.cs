using System;
using System.Collections;
using TwitterUCU;
using CognitiveCoreUCU;

namespace PII_Herencia
{
    public class Passanger : IPerson
    {
        public string name { get; set; }
        public string sureName { get; set; }
        public string id { get; set; }
        public bool isValid { get; set; }
        public Classification classification { get; set; }
        public string image { get; set; }
        public Passanger(string name, string sureName, string id, string image)
        {
            this.name = name;
            this.sureName = sureName;
            this.id = id;
            this.classification = Classification.Passanger;
            this.image = image;
            this.isValid = IsValid(image);
            System.Console.WriteLine(this.isValid);
        }
        public void Public()
        {
            string consumerKey = "CkovShLMNVCY0STsZlcRUFu99";
            string consumerKeySecret = "6rc35cHCyqFQSy4vIIjKiCYu31qqkBBkSS5BRlqeYCt5r7zO5B";
            string accessTokenSecret = "gNytQjJgLvurJekVU0wmBBkrR1Th40sJmTO8JDhiyUkuy";
            string accessToken = "1396065818-MeBf8ybIXA3FpmldORfBMdmrVJLVgijAXJv3B18";
            var twitter = new TwitterImage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            Console.WriteLine(twitter.PublishToTwitter("Welcome " + this.name + " " + this.sureName + " to UcuRideShare! He is our new " + Classification.Passanger.ToString(), this.image));
        }
        public bool IsValid(string image)
        {
            CognitiveFace cog = new CognitiveFace("620e818a46524ceb92628cde08068242", false);
            cog.Recognize(image);
            if (cog.FaceFound)
            {
                return true;
            }
            System.Console.WriteLine("Imagen inválida.");
            return false;
        }
    }
}
