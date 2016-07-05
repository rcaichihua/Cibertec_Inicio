namespace WebDeveloper.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class script01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        DateCreation = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ProductNumber = c.String(nullable: false),
                        Color = c.String(nullable: false),
                        ListPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SellEndDate = c.DateTime(),
                        Price = c.Double(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Product");
            DropTable("dbo.Client");
        }
    }
}
