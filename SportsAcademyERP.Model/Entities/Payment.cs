namespace SportsAcademyERP.Model.Entities
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int FeeId { get; set; }
        public int StudentId { get; set; }
        public int AcademyId { get; set; }
        public int BranchId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } = string.Empty; // Cash, Card, UPI, Bank Transfer
        public string TransactionReference { get; set; } = string.Empty;
        public DateTime PaymentDate { get; set; }
        public int Status { get; set; } // Completed, Failed, Pending, Refunded
        public string Remarks { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int ModifiedBy { get; set; }
    }
}
