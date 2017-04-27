﻿using stackoverflow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace stackoverflow.Controllers
{
    public class VoteController : Controller
    {
        // GET: Vote
        public ActionResult Up(int id)
        {
            var db = new ApplicationDbContext();
            var post = db.Posts.FirstOrDefault(f => f.Id == id);
            post.UpVotes += 1;
            db.SaveChanges();
            return PartialView("_voteDisplay", post);
        }
        // GET: Vote
        public ActionResult Down(int id)
        {
            var db = new ApplicationDbContext();
            var post = db.Posts.FirstOrDefault(f => f.Id == id);
            post.DownVotes += 1;
            db.SaveChanges();
            return PartialView("_voteDisplay", post);
        }
    }
}

