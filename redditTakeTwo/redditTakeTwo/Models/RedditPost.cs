using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace redditTakeTwo.Models
{
    public class RedditPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int? UpVotes { get; set; } = 2;
        public int? DownVotes { get; set; } = 1;
        public DateTime PostedAt { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

    }
}