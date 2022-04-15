namespace groupPassport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class student_changed_again : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Gender", c => c.Int());
            AddColumn("dbo.People", "MilitaryService", c => c.Int());
            AddColumn("dbo.People", "FormEducation", c => c.Int());
            AddColumn("dbo.People", "Education", c => c.Int());
            AddColumn("dbo.People", "Nationality_Id", c => c.Int());
            CreateIndex("dbo.People", "Nationality_Id");
            AddForeignKey("dbo.People", "Nationality_Id", "dbo.Nationalities", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "Nationality_Id", "dbo.Nationalities");
            DropIndex("dbo.People", new[] { "Nationality_Id" });
            DropColumn("dbo.People", "Nationality_Id");
            DropColumn("dbo.People", "Education");
            DropColumn("dbo.People", "FormEducation");
            DropColumn("dbo.People", "MilitaryService");
            DropColumn("dbo.People", "Gender");
        }
    }
}
