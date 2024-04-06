namespace ExamenInnovation.Models
{
    public class Goal
    {
        public Goal() { 
            Tasks = new List<Task>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public DateTime CreatedDate { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
