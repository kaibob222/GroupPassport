namespace groupPassport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teachercreated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Position", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Position");
        }
    }
}
