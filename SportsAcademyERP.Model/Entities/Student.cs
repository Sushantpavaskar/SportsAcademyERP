namespace SportsAcademyERP.Model.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Pincode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public int AcademyId { get; set; }
        public int BranchId { get; set; }
        public int SportId { get; set; }
        public int Level { get; set; }
        public string EnrollmentNumber { get; set; } = string.Empty;
        public DateTime EnrollmentDate { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int ModifiedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
