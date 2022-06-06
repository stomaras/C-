namespace SchoolPartBFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateTimeAttributeInDBTable2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "TuitionFees", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "TuitionFees");
        }
    }
}
