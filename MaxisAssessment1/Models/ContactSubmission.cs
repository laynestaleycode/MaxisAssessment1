namespace MaxisAssessment1.Models
{
    public class ContactSubmission
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Message {  get; set; } = string.Empty;
        public int? Age { get; set; }
        public string? ContactNumber { get; set; }
    }
}
