namespace CompleteWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MapItem : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MapItems", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MapItems", "IsActive", c => c.Int(nullable: false));
        }
    }
}
