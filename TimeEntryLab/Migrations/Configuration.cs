using System.Collections.Generic;
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
            Developer k = new Developer
            {
                FirstName = "Kate",
                LastName = "Ramsey",
                Email = "kateramsey@live.com",
                StartDate = new DateTime(2016, 02, 29)
            };

            k.Groups.Add(new Group
            {
                Name = "Backend"
            }); 
                   
           Industry media = new Industry
                {
                  Name  = "Media"
                };
            
            Client thv = new Client
            {
                Name = "THV11",
                Industry = media

            };
            k.Projects.Add(new Project
            {
                
            });

            db.Developers.AddOrUpdate(
                d => new { d.FirstName, d.LastName },
                k
                );

            var developers = Builder<Developer>.CreateListOfSize(10)
                    .All()
                    .With(m => m.FirstName = Faker.NameFaker.FirstName())
                    .With(m => m.LastName = Faker.NameFaker.LastName())
                    .With(m => m.Email = Faker.InternetFaker.Email())
                    .With(m => m.StartDate = Faker.DateTimeFaker.DateTime(new DateTime(1985, 01, 01), DateTime.Now))
                    .Build();

            db.Developers.AddOrUpdate(c => c.Id, developers.ToArray());

            var clients = Builder<Client>.CreateListOfSize(7)
                .All()
                .With(m => m.Name = Faker.NameFaker.Name())
                .Build();

            db.Clients.AddOrUpdate(c => c.Id, clients.ToArray());

        }
    }
}

