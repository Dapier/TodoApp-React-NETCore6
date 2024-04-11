using System;
using System.Collections.Generic;

namespace reactapp.Tasks.Models
{
    public partial class Task
    {
        public int IdTask { get; set; }
        public string? TaskDescription { get; set; }
        public DateTime? RegisterDate { get; set; }
    }
}
