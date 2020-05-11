namespace AutocompletePlacesDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addresses", "CustomerId", c => c.Int(nullable: false));
            AlterColumn("dbo.Addresses", "StreetNumber", c => c.String(maxLength: 10));
            AlterColumn("dbo.Addresses", "StreetName", c => c.String(maxLength: 20));
            AlterColumn("dbo.Addresses", "City", c => c.String(maxLength: 15));
            AlterColumn("dbo.Addresses", "ZipCode", c => c.String(maxLength: 10));
            AlterColumn("dbo.Addresses", "State", c => c.String(maxLength: 10));
            AlterColumn("dbo.Addresses", "Country", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Addresses", "Country", c => c.String());
            AlterColumn("dbo.Addresses", "State", c => c.String());
            AlterColumn("dbo.Addresses", "ZipCode", c => c.String());
            AlterColumn("dbo.Addresses", "City", c => c.String());
            AlterColumn("dbo.Addresses", "StreetName", c => c.String());
            AlterColumn("dbo.Addresses", "StreetNumber", c => c.String());
            DropColumn("dbo.Addresses", "CustomerId");
        }
    }
}
