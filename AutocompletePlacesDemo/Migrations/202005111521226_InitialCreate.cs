namespace AutocompletePlacesDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsBillingAddress = c.Boolean(nullable: false),
                        StreetNumber = c.String(),
                        StreetName = c.String(),
                        City = c.String(),
                        ZipCode = c.String(),
                        State = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Addresses");
        }
    }
}
