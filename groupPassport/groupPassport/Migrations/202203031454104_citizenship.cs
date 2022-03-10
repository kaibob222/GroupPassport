﻿namespace groupPassport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class citizenship : DbMigration
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Citizenships");
        }
    }
}
