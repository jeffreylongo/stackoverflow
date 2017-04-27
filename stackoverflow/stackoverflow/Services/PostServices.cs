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
        //get posts 
        public List<RedditPost> GetPosts()
        {
            var db = new ApplicationDbContext();
            var posts = db.Posts.ToList();
            return posts;
        }


    }
}