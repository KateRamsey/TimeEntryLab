using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


            Console.ReadLine();
        }
    }
}
