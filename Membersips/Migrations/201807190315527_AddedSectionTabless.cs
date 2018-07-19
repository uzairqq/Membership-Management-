namespace Membersips.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSectionTabless : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Sections", newName: "Section");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Section", newName: "Sections");
        }
    }
}
