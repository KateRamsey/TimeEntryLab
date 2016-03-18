using System.Collections.Generic;

namespace TimeEntryLab
{
    public class Client
    {
        public int ID { get; set; }
        public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
    }
}