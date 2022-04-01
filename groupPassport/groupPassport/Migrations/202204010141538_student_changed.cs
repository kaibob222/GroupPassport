namespace groupPassport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class student_changed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "ZachetkaNumber", c => c.String(maxLength: 6));
            AddColumn("dbo.People", "BirthDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "BirthDate");
            DropColumn("dbo.People", "ZachetkaNumber");
        }
    }
}
