namespace SportsNews.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Subscriptions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subscriptions",
                c => new
                    {
                        SubID = c.String(nullable: false, maxLength: 128),
                        SubName = c.String(),
                        Description = c.String(),
                        Category = c.String(),
                        Language = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.SubID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserID = c.String(nullable: false, maxLength: 128),
                        Username = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.User");
            DropTable("dbo.Subscriptions");
        }
    }
}
