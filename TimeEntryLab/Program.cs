using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzWare.NBuilder;

namespace TimeEntryLab
{
    class Program
    {
        static void Main(string[] args)
        {

            var developers = Builder<Developer>.CreateListOfSize(10)
                    .All()
                    .With(m => m.FirstName = Faker.NameFaker.FirstName())
                    .With(m => m.LastName = Faker.NameFaker.LastName())
                    .With(m => m.Email = Faker.InternetFaker.Email())
                    .With(m => m.StartDate = Faker.DateTimeFaker.DateTime(new DateTime(1985,01,01), DateTime.Now ))


                    .Build();


            var db = new Model1();

            foreach (var d in db.Developers)
            {
                Console.WriteLine($"{d.FirstName} {d.LastName}, {d.Email}, {d.StartDate.ToShortDateString()}");
            }


            Console.ReadLine();
        }
    }
}
