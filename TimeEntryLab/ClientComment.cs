using System.ComponentModel.DataAnnotations;

namespace TimeEntryLab
{
    public class ClientComment
    {
        public int Id { get; set; }
        public string Comment { get; set; }

        [Required]
        public virtual Client Client { get; set; } = new Client();
        [Required]
        public virtual Developer Developer { get; set; } = new Developer();
    }
}