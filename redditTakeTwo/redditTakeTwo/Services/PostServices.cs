using redditTakeTwo.Models;
using System;
using System.Collections.Generic;
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
    }
}