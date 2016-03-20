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
                Name = "Media"
            };

            Client thv = new Client
            {
                Name = "THV11",
                Industry = media

            };
            Project sr = new Project
            {
                Name = "Sales Report",
                Client = thv
            };
            k.Projects.Add(sr);

            TimeEntry srt = new TimeEntry
            {
                Day = DateTime.Now,
                TimeSpent = 3.4f,
                Developer = k,
                Project = sr,
            };



            var developers = Builder<Developer>.CreateListOfSize(10)
                .All()
                .With(m => m.FirstName = Faker.NameFaker.FirstName())
                .With(m => m.LastName = Faker.NameFaker.LastName())
                .With(m => m.Email = Faker.InternetFaker.Email())
                .With(m => m.StartDate = Faker.DateTimeFaker.DateTime(new DateTime(1985, 01, 01), DateTime.Now))
                .Build();
            developers.Add(k);



            var industry = Builder<Industry>.CreateListOfSize(4)
                .All()
                .With(i => i.Name = Faker.CompanyFaker.BS())
                .Build();
            industry.Add(media);



            var clients = Builder<Client>.CreateListOfSize(7)
                .All()
                .With(m => m.Name = Faker.CompanyFaker.Name())
                .With(i=>i.Industry=industry[3])
                .Build();
            clients.Add(thv);




            var timeentries = new List<TimeEntry> {srt};







            var project = Builder<Project>.CreateListOfSize(6)
                .All()
                .With(n => n.Name = Faker.StringFaker.Alpha(8))
                .With(p=>p.Client = thv)
                .Build();
            project.Add(sr);




            ClientComment thvcomment = new ClientComment
            {
                Developer = k,
                Client = thv,
                Comment = "They are awesome to work with"
            };

            IndustryComment mediaComment = new IndustryComment()
            {
                Developer = k,
                Industry = media,
                Comment = "Media people are strange"
            };

            ProjectComment srComment = new ProjectComment()
            {
                Comment = "This project sucks!",
                Developer = k,
                Project = sr
            };

            k.ClientComments.Add(thvcomment);
            k.IndustryComments.Add(mediaComment);
            k.ProjectComments.Add(srComment);

            db.Developers.AddOrUpdate(c => c.Id, developers.ToArray());
            db.Projects.AddOrUpdate(p => p.ID, project.ToArray());
            db.TimeEntries.AddOrUpdate(g => g.Id, timeentries.ToArray());
            db.Clients.AddOrUpdate(c => c.Id, clients.ToArray());
            db.Industries.AddOrUpdate(i => i.Id, industry.ToArray());
        }
    }
}

