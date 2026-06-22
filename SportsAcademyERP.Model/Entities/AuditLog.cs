namespace SportsAcademyERP.Model.Entities
{
    public class AuditLog
    {
        public int AuditLogId { get; set; }
        public int UserId { get; set; }
        public int AcademyId { get; set; }
        public string Module { get; set; } = string.Empty;
        public string Action { get; set; } = string.Empty; // Create, Update, Delete, View
        public string TableName { get; set; } = string.Empty;
        public int RecordId { get; set; }
        public string OldValues { get; set; } = string.Empty;
        public string NewValues { get; set; } = string.Empty;
        public string IPAddress { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
