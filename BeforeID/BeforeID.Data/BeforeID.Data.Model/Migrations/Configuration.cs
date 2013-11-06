using BeforeID.Data.Model.Context;
using BeforeID.Data.Model.Seeders.CategorySeed;
using BeforeID.Data.Model.Seeders.PostSeed;
using BeforeID.Data.Model.Seeders.UserSeed;

namespace BeforeID.Data.Model.Migrations
{
    using System.Data.Entity;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<BeforeID.Data.Model.Context.BidContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BidContext>());
        }

        protected override void Seed(BeforeID.Data.Model.Context.BidContext context)
        {
            BaseCategorySeeder.Seed(context);
            BaseUserSeeder.Seed(context);
            BasePostsSeeder.Seed(context);
        }
    }
}
