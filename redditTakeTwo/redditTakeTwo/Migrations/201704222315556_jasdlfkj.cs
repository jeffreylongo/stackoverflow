namespace redditTakeTwo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jasdlfkj : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RedditPosts", "UpVotes", c => c.Int());
            AlterColumn("dbo.RedditPosts", "DownVotes", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RedditPosts", "DownVotes", c => c.Int(nullable: false));
            AlterColumn("dbo.RedditPosts", "UpVotes", c => c.Int(nullable: false));
        }
    }
}
