namespace ACME.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Acmev1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        EmployeeNumber = c.String(),
                        EmployedDate = c.String(),
                        TerminatedDate = c.DateTime(nullable: true),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        personId = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                        BirthDate = c.DateTime(nullable: true),
                    })
                .PrimaryKey(t => t.personId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "PersonId", "dbo.People");
            DropIndex("dbo.Employees", new[] { "PersonId" });
            DropTable("dbo.People");
            DropTable("dbo.Employees");
        }
    }
}
