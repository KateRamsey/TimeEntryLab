namespace TimeEntryLab
{
    public class IndustryComment
    {
        public int Id { get; set; }
        public string Comment { get; set; }

        public virtual Developer Developer { get; set; }
        public virtual Industry Industry { get; set; }
    }
}