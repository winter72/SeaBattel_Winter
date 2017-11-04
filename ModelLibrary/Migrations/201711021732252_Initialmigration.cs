namespace ModelLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BattelFields",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Field = c.String(nullable: false, storeType: "xml"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UsersAccount",
                c => new
                    {
                        UserAccountId = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 128),
                        HashPassword = c.String(nullable: false),
                        Salt = c.String(nullable: false),
                        IsActivated = c.Boolean(nullable: false),
                        VerifyCode = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.UserAccountId)
                .Index(t => t.Email, unique: true);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserAccountId = c.Int(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Login = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UsersAccount", t => t.UserAccountId, cascadeDelete: true)
                .Index(t => t.UserAccountId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "UserAccountId", "dbo.UsersAccount");
            DropIndex("dbo.Users", new[] { "UserAccountId" });
            DropIndex("dbo.UsersAccount", new[] { "Email" });
            DropTable("dbo.Users");
            DropTable("dbo.UsersAccount");
            DropTable("dbo.BattelFields");
        }
    }
}
