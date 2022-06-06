namespace lab_04.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (1, 'DEVELOPMENT')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (2, 'BUSSINESS')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (3, 'MARKETING')");
        }
        
        public override void Down()
        {
        }
    }
}
