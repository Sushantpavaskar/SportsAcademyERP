namespace SportsAcademyERP.Model.Entities
{
    public class Branch
    {
        public int BranchId { get; set; }
        public int AcademyId { get; set; }
        public string BranchName { get; set; } = string.Empty;
        public string BranchCode { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Pincode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string ManagerName { get; set; } = string.Empty;
        public string ManagerPhone { get; set; } = string.Empty;
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int ModifiedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
