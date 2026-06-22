namespace SportsAcademyERP.Model.Entities
{
    public class Fee
    {
        public int FeeId { get; set; }
        public int StudentId { get; set; }
        public int AcademyId { get; set; }
        public int BranchId { get; set; }
        public decimal Amount { get; set; }
        public string FeeType { get; set; } = string.Empty; // Monthly, Quarterly, Annually
        public int Month { get; set; }
        public int Year { get; set; }
        public DateTime DueDate { get; set; }
        public int Status { get; set; } // Pending, Paid, Overdue, Cancelled
        public string Remarks { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int ModifiedBy { get; set; }
    }
}
