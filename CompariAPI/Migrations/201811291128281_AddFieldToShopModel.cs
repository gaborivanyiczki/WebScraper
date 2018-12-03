namespace CompariAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFieldToShopModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Shop", "SpaceCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Shop", "SpaceCode");
        }
    }
}
