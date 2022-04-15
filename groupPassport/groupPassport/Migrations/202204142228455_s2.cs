namespace groupPassport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class s2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.People", "ZachetkaNumber");
            DropColumn("dbo.People", "BirthDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "BirthDate", c => c.DateTime());
            AddColumn("dbo.People", "ZachetkaNumber", c => c.String(maxLength: 6));
        }
    }
}
