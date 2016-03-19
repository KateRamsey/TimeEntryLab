using System.ComponentModel.DataAnnotations;

namespace TimeEntryLab
{
    public class IndustryComment
    {
        public int Id { get; set; }
        public string Comment { get; set; }

        [Required]
        public virtual Developer Developer { get; set; }
        [Required]
        public virtual Industry Industry { get; set; }
    }
}