using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TimeEntryLab
{
    public class ProjectComment
    {
        public int Id { get; set; }
        public string Comment { get; set; }

        [Required]
        public virtual Project Project { get; set; }
        [Required]
        public virtual Developer Developer { get; set; }

    }
}