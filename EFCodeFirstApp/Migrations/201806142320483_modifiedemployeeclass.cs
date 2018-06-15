namespace EFCodeFirstApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifiedemployeeclass : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "YearOfEmployment", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Employees", "Salary", c => c.String());
            AlterColumn("dbo.Employees", "DateOfBirth", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "DateOfBirth", c => c.DateTime());
            AlterColumn("dbo.Employees", "Salary", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "YearOfEmployment", c => c.DateTime());
        }
    }
}
