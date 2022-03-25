namespace groupPassport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class strange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "Position", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "Position", c => c.String(maxLength: 20));
        }
    }
}
