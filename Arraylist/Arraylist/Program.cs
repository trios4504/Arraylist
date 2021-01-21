using System;
using System.Collections.Generic;

namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            instagramUser user1 = new instagramUser();

            user1.userName = "Thomas";
            user1.totalViews = 2;
            user1.Likes = 3;
            user1.Comments = new List<string>();
            user1.Comments.Add("This is my first comment");
            user1.Comments.Add("A comment from another user");
            user1.Comments.Add("One more comment");

            Console.WriteLine("The User " + user1.userName + " has a total of " + user1.totalViews + " views and " + user1.Likes + " likes.");

            Console.WriteLine("The user has the following comments:");
            foreach(var item in user1.Comments)
            {
                Console.WriteLine(item);
            }
        }
    }
}


public class instagramUser
{
    public string userName { get; set; }
    public int totalViews { get; set; }
    public int Likes { get; set; }
    public List<string> Comments { get; set; }
}
