using System;
using System.Collections.Generic;

namespace reactapp.Models
{
    public partial class Task
    {
        public int IdTask { get; set; }
        public string? DescriptionTask { get; set; }
        public DateTime? RegisterDate { get; set; }
    }
}
