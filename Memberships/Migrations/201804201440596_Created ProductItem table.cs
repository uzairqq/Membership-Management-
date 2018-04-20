namespace Memberships.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedProductItemtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Product Item",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductId, t.ItemId });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Product Item");
        }
    }
}
