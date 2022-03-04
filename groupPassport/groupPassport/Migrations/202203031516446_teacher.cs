namespace groupPassport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teacher : DbMigration
    {
        public override void Up()
        {
            CreateTable(
            "dbo.Teachers",
            c => new
            {
                Id = c.Int(nullable: false, identity: true),
                FirstName = c.String(maxLength: 50),
                SurName = c.String(maxLength: 50),
                MiddleName = c.String(maxLength: 50)
            })
            .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropTable("dbo.Teachers");
        }
    }
}
