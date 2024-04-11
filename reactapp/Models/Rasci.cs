using System;
using System.Collections.Generic;

namespace reactapp.Models
{
    public partial class Rasci
    {
        public int IdJobCode { get; set; }
        public string? ProcessArea { get; set; }
        public string? DescriptionJobCode { get; set; }
        public string? PlantScPlanning { get; set; }
        public string? PlantSupplierLeader { get; set; }
        public string? ClusterTeams { get; set; }
        public string? CategoryTeams { get; set; }
        public string? TechnicalProductivity { get; set; }
        public string? CentraolTeamProductivity { get; set; }
        public string? ResilienceTeams { get; set; }
        public string? Sqe { get; set; }
        public string? AdvanceManufacturing { get; set; }
        public string? Finance { get; set; }
    }
}
