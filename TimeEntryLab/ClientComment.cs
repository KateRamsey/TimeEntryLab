namespace TimeEntryLab
{
    public class ClientComment
    {
        public int Id { get; set; }
        public string Comment { get; set; }

        public virtual Client Client { get; set; } = new Client();
        public virtual Developer Developer { get; set; } = new Developer();
    }
}