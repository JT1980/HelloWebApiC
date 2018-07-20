namespace HelloWebApiC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HelloWebApiC.Models.HelloWebApiCContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HelloWebApiC.Models.HelloWebApiCContext context)
        {

            context.People.AddOrUpdate(p => p.Id,
               new Models.Person { Id = 1, FirstName = "Hello", LastName = "World" });
            //  This method will be called after migrating to the latest version.

               //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
               //  to avoid creating duplicate seed data. E.g.
               //
               //    context.People.AddOrUpdate(
               //      p => p.FullName,
               //      new Person { FullName = "Andrew Peters" },
               //      new Person { FullName = "Brice Lambson" },
               //      new Person { FullName = "Rowan Miller" }
               //    );
               //
        }
    }
}
