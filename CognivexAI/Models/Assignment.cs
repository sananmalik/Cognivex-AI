using System;
using System.Collections.Generic;

namespace CognivexAI.Models
{
    public class Assignment
    {
        public int AssignmentId { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public List<TaskItem> Tasks { get; set; } = new();
    }
}