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
            var DevList = new List<Developer>();
            Developer k = new Developer
            {
                FirstName = "Kate",
                LastName = "Ramsey",
                Email = "kateramsey@live.com",
                StartDate = new DateTime(2016, 02, 29)
            };
            DevList.Add(k);

            foreach (var d in DevList)
            {
                db.Developers.Add(d);
                db.SaveChanges();
            }
        }
    }
}
