namespace scanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addednewtabels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ALL_CONTENT",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CONTENT = c.String(maxLength: 1000, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ALL_H1",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ALL_H1 = c.String(maxLength: 1000, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ALL_P",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ALL_P = c.String(maxLength: 1000, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.LINKS", "SORT", c => c.Int());
            AddColumn("dbo.LINKS", "WEIGHT", c => c.Int());
            AddColumn("dbo.LINKS", "META_DESCRIPTION", c => c.String(maxLength: 255, storeType: "nvarchar"));
            AddColumn("dbo.LINKS", "META_KEYWORDS", c => c.String(maxLength: 255, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.LINKS", "META_KEYWORDS");
            DropColumn("dbo.LINKS", "META_DESCRIPTION");
            DropColumn("dbo.LINKS", "WEIGHT");
            DropColumn("dbo.LINKS", "SORT");
            DropTable("dbo.ALL_P");
            DropTable("dbo.ALL_H1");
            DropTable("dbo.ALL_CONTENT");
        }
    }
}
