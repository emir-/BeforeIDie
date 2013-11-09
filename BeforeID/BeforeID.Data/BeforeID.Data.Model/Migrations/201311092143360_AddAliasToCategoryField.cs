namespace BeforeID.Data.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAliasToCategoryField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CategoryAlias", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "CategoryAlias");
        }
    }
}
