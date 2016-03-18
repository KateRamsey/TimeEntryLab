using System.Collections.Generic;

namespace TimeEntryLab
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

        public virtual Industry Industry { get; set; } = new Industry();
    }
}