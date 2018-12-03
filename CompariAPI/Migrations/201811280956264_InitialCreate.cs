namespace CompariAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Shop",
                c => new
                    {
                        ShopID = c.Int(nullable: false, identity: true),
                        ShopName = c.String(),
                        ShopLink = c.String(),
                        ShopSearchLink = c.String(),
                    })
                .PrimaryKey(t => t.ShopID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Shop");
        }
    }
}
