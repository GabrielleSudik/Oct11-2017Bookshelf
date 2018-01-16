namespace Oct11_2017Bookshelf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAuthors1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "CategoryID", "dbo.Categories");
            AddColumn("dbo.Books", "AuthorID", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "Category_ID", c => c.Int());
            CreateIndex("dbo.Books", "AuthorID");
            CreateIndex("dbo.Books", "Category_ID");
            AddForeignKey("dbo.Books", "AuthorID", "dbo.Categories", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Books", "Category_ID", "dbo.Categories", "ID");
            DropColumn("dbo.Books", "Author");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Author", c => c.String());
            DropForeignKey("dbo.Books", "Category_ID", "dbo.Categories");
            DropForeignKey("dbo.Books", "AuthorID", "dbo.Categories");
            DropIndex("dbo.Books", new[] { "Category_ID" });
            DropIndex("dbo.Books", new[] { "AuthorID" });
            DropColumn("dbo.Books", "Category_ID");
            DropColumn("dbo.Books", "AuthorID");
            AddForeignKey("dbo.Books", "CategoryID", "dbo.Categories", "ID", cascadeDelete: true);
        }
    }
}
