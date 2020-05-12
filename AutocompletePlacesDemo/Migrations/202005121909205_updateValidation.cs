namespace AutocompletePlacesDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Addresses", "StreetName", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Addresses", "StreetName", c => c.String(maxLength: 20));
        }
    }
}
