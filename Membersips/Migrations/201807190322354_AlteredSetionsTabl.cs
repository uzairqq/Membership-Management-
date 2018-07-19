namespace Membersips.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteredSetionsTabl : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Section", "Title", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Section", "Title", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
