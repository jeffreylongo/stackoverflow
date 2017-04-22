using redditTakeTwo.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace redditTakeTwo.Services
{
    public class PostServices
    {
        public List<RedditPost> GetPosts()
        {
            var db = new ApplicationDbContext();
            var posts = db.Posts.ToList();
            return posts;
        }

        //add post
        var post = new RedditPost<post>
            {
                new Teams{ Image="/Images/dartboard.png", SportId =3,Name="Tampa Dart Dynamos", NumberOfPlayers = 8 },
                new Teams { Image="/Images/pingpong.jpg", SportId = 6, Name = "St Pete Ping Pong Powerhouse", NumberOfPlayers = 8},
                new Teams { Image="/Images/golf.jpg", SportId = 5, Name ="Orlando Golf Gang", NumberOfPlayers= 8},
                new Teams { Image="/Images/dartboard.png", SportId = 5, Name ="Buffalo BullsEyes", NumberOfPlayers= 8},
                new Teams { Image="/Images/pingpong.jpg", SportId = 5, Name ="Philly Paddlers", NumberOfPlayers= 8},
                new Teams { Image="/Images/golf.jpg", SportId = 5, Name ="Portland Putters", NumberOfPlayers= 8},
            };
        teams.ForEach(team => db.Teams.AddOrUpdate(t => t.Name, team));
            db.SaveChanges();
    }
}