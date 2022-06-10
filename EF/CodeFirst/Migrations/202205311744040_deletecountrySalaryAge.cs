namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletecountrySalaryAge : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Students", "Salary");
            DropColumn("dbo.Students", "Age");
            DropColumn("dbo.Students", "Country");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Country", c => c.String());
            AddColumn("dbo.Students", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "Salary", c => c.Int(nullable: false));
        }
    }
}
