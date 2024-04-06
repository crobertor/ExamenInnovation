namespace ExamenInnovation.Models
{
    public class Task
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public DateTime Date { get; set; }
        public string Status { get; set; } = default!;
        public bool Priority { get; set; }
        public Guid GoalId { get; set; }
    }
}