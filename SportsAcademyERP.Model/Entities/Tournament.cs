namespace SportsAcademyERP.Model.Entities
{
    public class Tournament
    {
        public int TournamentId { get; set; }
        public string TournamentName { get; set; } = string.Empty;
        public string TournamentDescription { get; set; } = string.Empty;
        public int AcademyId { get; set; }
        public int BranchId { get; set; }
        public int SportId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; } = string.Empty;
        public string TournamentType { get; set; } = string.Empty; // Internal, External
        public int Status { get; set; } // Planned, Ongoing, Completed, Cancelled
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int ModifiedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
