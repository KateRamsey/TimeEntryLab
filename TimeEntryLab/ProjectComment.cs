using System.Collections.Generic;

namespace TimeEntryLab
{
    public class ProjectComment
    {
        public int Id { get; set; }
        public string Comment { get; set; }

        public virtual Project Project { get; set; }
        public virtual Developer Developer { get; set; }

    }
}