using System.Collections.Generic;
using System.Net.Http;

namespace TimeEntryLab
{
    public class Project
    {
        public int ID { get; set; }
        public virtual ICollection<Developer> Developers { get; set; } = new List<Developer>();

        public virtual Client Client { get; set; }
    }
}