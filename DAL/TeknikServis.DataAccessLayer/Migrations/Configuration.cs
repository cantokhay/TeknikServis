using System.Data.Entity.Migrations;
using TeknikServis.DataAccessLayer.Context;
using TeknikServis.DataAccessLayer.SeedData;

namespace TeknikServis.DataAccessLayer.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<TeknikServis.DataAccessLayer.Context.TeknikServisContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; // Manuel migration
        }

        protected override void Seed(TeknikServisContext context)
        {
            SeedDataGenerator.SeedAsync().Wait();
        }
    }
}
