namespace SportsAcademyERP.Model.Entities
{
    public class Academy
    {
        public int AcademyId { get; set; }
        public string AcademyName { get; set; } = string.Empty;
        public string AcademyCode { get; set; } = string.Empty;
        public int SportId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Pincode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string RegistrationNumber { get; set; } = string.Empty;
        public DateTime RegistrationDate { get; set; }
        public string OwnerName { get; set; } = string.Empty;
        public string OwnerEmail { get; set; } = string.Empty;
        public string OwnerPhoneNumber { get; set; } = string.Empty;
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int ModifiedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
