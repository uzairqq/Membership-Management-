namespace Memberships.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedSubscriptionProduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subscription Product",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        SubscriptionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductId, t.SubscriptionId });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Subscription Product");
        }
    }
}
