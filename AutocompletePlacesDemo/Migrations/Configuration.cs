namespace AutocompletePlacesDemo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AutocompletePlacesDemo.Data.AutocompletePlacesDemoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "AutocompletePlacesDemo.Data.AutocompletePlacesDemoContext";
        }

        protected override void Seed(AutocompletePlacesDemo.Data.AutocompletePlacesDemoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
