namespace SportsAcademyERP.Model.Entities
{
    public class Sport
    {
        public int SportId { get; set; }
        public string SportName { get; set; } = string.Empty;
        public string SportCode { get; set; } = string.Empty;
        public string SportIcon { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
