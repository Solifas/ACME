namespace ACME.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBGENERATEid1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "ContactNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "ContactNumber");
        }
    }
}
