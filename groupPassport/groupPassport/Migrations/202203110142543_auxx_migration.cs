namespace groupPassport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class auxx_migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Citizenships",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonCitizenship = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Documents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DocumentType = c.Int(nullable: false),
                        DocumentNumber = c.String(maxLength: 50),
                        StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.Nationalities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonNationality = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Documents", "StudentId", "dbo.People");
            DropIndex("dbo.Documents", new[] { "StudentId" });
            DropTable("dbo.Nationalities");
            DropTable("dbo.Documents");
            DropTable("dbo.Citizenships");
        }
    }
}
