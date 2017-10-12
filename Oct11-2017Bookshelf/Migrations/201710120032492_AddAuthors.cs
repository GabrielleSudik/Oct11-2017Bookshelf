namespace Oct11_2017Bookshelf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAuthors : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Author", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Author");
        }
    }
}
