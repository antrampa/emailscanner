namespace scanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EMAILS",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        URL = c.String(maxLength: 150, storeType: "nvarchar"),
                        EMAIL = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.EMAIL);
            
            CreateTable(
                "dbo.H1_TEXTS",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        URL = c.String(maxLength: 150, storeType: "nvarchar"),
                        TEXT = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.TEXT);
            
            CreateTable(
                "dbo.LINKS",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        URL = c.String(maxLength: 255, storeType: "nvarchar"),
                        HAS_SCANNED = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.H1_TEXTS", new[] { "TEXT" });
            DropIndex("dbo.EMAILS", new[] { "EMAIL" });
            DropTable("dbo.LINKS");
            DropTable("dbo.H1_TEXTS");
            DropTable("dbo.EMAILS");
        }
    }
}
