namespace SchoolPartBFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateTimeAttributeInDBTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "BirthDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "BirthDate");
        }
    }
}
