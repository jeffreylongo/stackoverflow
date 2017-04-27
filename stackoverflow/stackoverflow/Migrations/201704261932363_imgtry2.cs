namespace redditTakeTwo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imgtry2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RedditPosts", "Img", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.RedditPosts", "Img");
        }
    }
}
