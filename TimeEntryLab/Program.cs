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
            char UserInput;
            bool KeepGoing = true;

            //to do: Make report options in console app instead of writing all of them
            while (KeepGoing)
            {
                Console.WriteLine("Which report would you like to see?");
                Console.WriteLine("1 for developers");
                Console.WriteLine("2 for clients");
                Console.WriteLine("3 for projects");
                Console.WriteLine("4 for billing hours");
                UserInput = Console.ReadLine().ToCharArray()[0];

                if (UserInput == '1')
                {


                    foreach (var d in db.Developers)
                    {
                        Console.WriteLine($"{d.FirstName} {d.LastName}, {d.Email}, {d.StartDate.ToShortDateString()}");
                    }

                    Console.WriteLine();
                }

                if (UserInput == '2')
                {
                    foreach (var c in db.Clients)
                    {
                        Console.WriteLine($"Client ID: {c.Id}, Client Name: {c.Name}");
                    }

                    Console.WriteLine();
                }

                if (UserInput == '3')
                {
                    foreach (var p in db.Projects)
                    {
                        Console.WriteLine($"Project ID: {p.ID}, is named {p.Name}, for client {p.Client.Name}");
                    }

                    Console.WriteLine();
                }

                if (UserInput == '4')
                {
                    var totalBillingHours = 0f;
                    foreach (var p in db.Projects)
                    {
                        foreach (var t in db.TimeEntries)
                        {
                            if (t.Project == p)
                            {
                                totalBillingHours += t.TimeSpent;
                            }
                            Console.WriteLine($"Total Billing Hours for {p.Name} is {totalBillingHours}");
                            totalBillingHours = 0;
                        }
                    }
                }


                Console.WriteLine("Would you like to run another repot? (Y)es or (N)o");
                UserInput = Console.ReadLine().ToCharArray()[0];
                if (UserInput == 'N' || UserInput == 'n')
                {
                    KeepGoing = false;
                }
                Console.Clear();
            }
        }
    }
}
