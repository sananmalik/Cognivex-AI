namespace CognivexAI.Models
{
    public class TaskItem
    {
        public int TaskItemId { get; set; }

        public string TaskTitle { get; set; } = string.Empty;

        public string Priority { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;

        public int EstimatedHours { get; set; }

        public int AssignmentId { get; set; }

        public Assignment? Assignment { get; set; }
    }
}