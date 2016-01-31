namespace LearnWithQB.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LearnWithQB.Server.Data.LearnWithQBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LearnWithQB.Server.Data.LearnWithQBContext context)
        {
        }
    }
}
