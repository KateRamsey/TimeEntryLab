using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;

namespace TimeEntryLab
{
    public class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Developer> Developers { get; set; } = new List<Developer>();

        [Required]
        public virtual Client Client { get; set; }

        public virtual ICollection<ProjectComment> ProjectComments { get; set; } = new List<ProjectComment>();

        public virtual ICollection<TimeEntry> TimeEntries { get; set; } = new List<TimeEntry>();

    }
}