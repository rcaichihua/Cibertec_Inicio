namespace WebDeveloper.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstChangeofdboClient : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.Client", "Apellidos", "LastName");//mantiene la data
            //AddColumn("dbo.Client", "LastName", c => c.String(nullable: false));//elmina la data
            //DropColumn("dbo.Client", "Apellidos");//elimina la data
        }
        
        public override void Down()
        {
            RenameColumn("dbo.Client", "LastName", "Apellidos");//mantiene la data
            //AddColumn("dbo.Client", "Apellidos", c => c.String(nullable: false));
            //DropColumn("dbo.Client", "LastName");
        }
    }
}
