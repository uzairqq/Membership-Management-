namespace Membersips.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class checkingsection : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Section", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Section", "Name");
        }
    }
}
