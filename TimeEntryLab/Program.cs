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

            var db = new Model1();

            foreach (var d in db.Developers)
            {
                Console.WriteLine($"{d.FirstName} {d.LastName}, {d.Email}, {d.StartDate.ToShortDateString()}");
            }

            Console.WriteLine();

            foreach (var c in db.Clients)
            {
                Console.WriteLine($"Client ID: {c.Id}, Client Name: {c.Name}");
            }

            Console.WriteLine();

            foreach (var p in db.Projects)
            {
                Console.WriteLine($"Project ID: {p.ID}, is named {p.Name}, for client {p.Client.Name}");
            }

            Console.ReadLine();
        }
    }
}
