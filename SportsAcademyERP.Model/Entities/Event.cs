namespace SportsAcademyERP.Model.Entities
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventName { get; set; } = string.Empty;
        public string EventDescription { get; set; } = string.Empty;
        public int AcademyId { get; set; }
        public int BranchId { get; set; }
        public int SportId { get; set; }
        public DateTime EventDate { get; set; }
        public string EventTime { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int Status { get; set; } // Scheduled, Ongoing, Completed, Cancelled
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int ModifiedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
