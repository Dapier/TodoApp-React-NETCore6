using System;
using System.Collections.Generic;

namespace reactapp.Tasks.Models
{
    public partial class Todo
    {
        public int IdTask { get; set; }
        public string? TaskDescription { get; set; }
        public DateTime? RegisterDate { get; set; }
    }
}
