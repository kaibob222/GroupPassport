namespace groupPassport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class studentclass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "GroupId", c => c.Int());
            AddColumn("dbo.People", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.People", "GroupId");
            AddForeignKey("dbo.People", "GroupId", "dbo.Groups", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "GroupId", "dbo.Groups");
            DropIndex("dbo.People", new[] { "GroupId" });
            DropColumn("dbo.People", "Discriminator");
            DropColumn("dbo.People", "GroupId");
        }
    }
}
