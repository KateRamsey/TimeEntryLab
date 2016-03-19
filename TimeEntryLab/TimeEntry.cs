using System;
using System.ComponentModel.DataAnnotations;

namespace TimeEntryLab
{
    public class TimeEntry
    {
        public int Id { get; set; }
        public DateTime Day { get; set; }
        public float TimeSpent { get; set; }

        [Required]
        public virtual Project Project { get; set; } = new Project();
        [Required]
        public virtual Developer Developer { get; set; } = new Developer();
    }
}