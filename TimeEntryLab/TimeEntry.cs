using System;

namespace TimeEntryLab
{
    public class TimeEntry
    {
        public int Id { get; set; }
        public DateTime Day { get; set; }
        public float TimeSpent { get; set; }

        public virtual Project Project { get; set; } = new Project();
        public virtual Developer Developer { get; set; } = new Developer();
    }
}