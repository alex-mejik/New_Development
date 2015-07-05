namespace CompleteWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UploadedBy : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SliderImages", "UploadedBy", c => c.String());
            AddColumn("dbo.MapItems", "Longitude", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MapItems", "Longitude");
            DropColumn("dbo.SliderImages", "UploadedBy");
        }
    }
}
