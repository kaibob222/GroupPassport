namespace groupPassport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_citizenship_student : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Citizenship_Id", c => c.Int());
            CreateIndex("dbo.People", "Citizenship_Id");
            AddForeignKey("dbo.People", "Citizenship_Id", "dbo.Citizenships", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "Citizenship_Id", "dbo.Citizenships");
            DropIndex("dbo.People", new[] { "Citizenship_Id" });
            DropColumn("dbo.People", "Citizenship_Id");
        }
    }
}
