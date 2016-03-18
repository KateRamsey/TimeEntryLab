using System.Collections.Generic;

namespace TimeEntryLab
{
    public class Group
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Developer> Developers { get; set; } = new List<Developer>();
    }
}