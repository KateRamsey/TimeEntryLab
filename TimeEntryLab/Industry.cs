﻿using System.Collections.Generic;

namespace TimeEntryLab
{
    public class Industry
    {
        public int Id { get; set; }
        public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

        public virtual ICollection<IndustryComment> IndustryComments { get; set; } = new List<IndustryComment>();
    }
}