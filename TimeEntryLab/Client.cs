using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TimeEntryLab
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

        [Required]
        public virtual Industry Industry { get; set; } = new Industry();
    }
}