namespace groupPassport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignkeyIdadded : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.People", "Citizenship_Id", "dbo.Citizenships");
            DropForeignKey("dbo.People", "Nationality_Id", "dbo.Nationalities");
            RenameColumn(table: "dbo.People", name: "Citizenship_Id", newName: "CitizenshipId");
            RenameColumn(table: "dbo.People", name: "Nationality_Id", newName: "NationalityId");
            RenameIndex(table: "dbo.People", name: "IX_Nationality_Id", newName: "IX_NationalityId");
            RenameIndex(table: "dbo.People", name: "IX_Citizenship_Id", newName: "IX_CitizenshipId");
            AddForeignKey("dbo.People", "CitizenshipId", "dbo.Citizenships", "Id", cascadeDelete: true);
            AddForeignKey("dbo.People", "NationalityId", "dbo.Nationalities", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "NationalityId", "dbo.Nationalities");
            DropForeignKey("dbo.People", "CitizenshipId", "dbo.Citizenships");
            RenameIndex(table: "dbo.People", name: "IX_CitizenshipId", newName: "IX_Citizenship_Id");
            RenameIndex(table: "dbo.People", name: "IX_NationalityId", newName: "IX_Nationality_Id");
            RenameColumn(table: "dbo.People", name: "NationalityId", newName: "Nationality_Id");
            RenameColumn(table: "dbo.People", name: "CitizenshipId", newName: "Citizenship_Id");
            AddForeignKey("dbo.People", "Nationality_Id", "dbo.Nationalities", "Id");
            AddForeignKey("dbo.People", "Citizenship_Id", "dbo.Citizenships", "Id");
        }
    }
}
