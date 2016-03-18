using FizzWare.NBuilder;

namespace TimeEntryLab.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TimeEntryLab.Model1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TimeEntryLab.Model1 db)
        {
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

            Developer k = new Developer
            {
                FirstName = "Kate",
                LastName = "Ramsey",
                Email = "ka@live.com",
                StartDate = new DateTime(2016, 02, 29)
            };

            db.Developers.AddOrUpdate(
                d => new { d.FirstName, d.LastName },
                k
                );

            if (!db.Developers.Any())
            {
                var developers = Builder<Developer>.CreateListOfSize(10)
                        .All()
                        .With(m => m.FirstName = Faker.NameFaker.FirstName())
                        .With(m => m.LastName = Faker.NameFaker.LastName())
                        .With(m => m.Email = Faker.InternetFaker.Email())
                        .With(m => m.StartDate = Faker.DateTimeFaker.DateTime(new DateTime(1985, 01, 01), DateTime.Now))


                        .Build();

                db.Developers.AddOrUpdate(c => c.Id, developers.ToArray());
            }



        }
    }
}

