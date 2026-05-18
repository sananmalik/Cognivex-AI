namespace CognivexAI.DTOs
{
    public class AiTaskDto
    {
        public string TaskTitle { get; set; } = string.Empty;

        public string Priority { get; set; } = string.Empty;

        public int EstimatedHours { get; set; }
    }
}