namespace groupPassport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class groupchanged : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TeacherGroups",
                c => new
                    {
                        Teacher_Id = c.Int(nullable: false),
                        Group_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Teacher_Id, t.Group_Id })
                .ForeignKey("dbo.People", t => t.Teacher_Id, cascadeDelete: true)
                .ForeignKey("dbo.Groups", t => t.Group_Id, cascadeDelete: true)
                .Index(t => t.Teacher_Id)
                .Index(t => t.Group_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeacherGroups", "Group_Id", "dbo.Groups");
            DropForeignKey("dbo.TeacherGroups", "Teacher_Id", "dbo.People");
            DropIndex("dbo.TeacherGroups", new[] { "Group_Id" });
            DropIndex("dbo.TeacherGroups", new[] { "Teacher_Id" });
            DropTable("dbo.TeacherGroups");
        }
    }
}
