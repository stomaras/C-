namespace MyDatabasee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Price");
        }
    }
}
