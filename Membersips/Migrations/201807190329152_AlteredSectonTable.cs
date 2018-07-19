namespace Membersips.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteredSectonTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Section", "Title", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Section", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Section", "Name", c => c.String());
            AlterColumn("dbo.Section", "Title", c => c.String());
        }
    }
}
