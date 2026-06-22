namespace SportsAcademyERP.Model.Entities
{
    public class Attendance
    {
        public int AttendanceId { get; set; }
        public int StudentId { get; set; }
        public int CoachId { get; set; }
        public int AcademyId { get; set; }
        public int BranchId { get; set; }
        public int SportId { get; set; }
        public DateTime AttendanceDate { get; set; }
        public string Status { get; set; } = "Present"; // Present, Absent, Leave
        public string Remarks { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int ModifiedBy { get; set; }
    }
}
