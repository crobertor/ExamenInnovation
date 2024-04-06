using ExamenInnovation.Models;

namespace ExamenInnovation.Services
{
    public interface IGloalService
    {
        
        public Task<List<Goal>> GetAll();

        public Task<Goal> GetById(Guid Id);

        public System.Threading.Tasks.Task AddGoal(Goal goal);

        public System.Threading.Tasks.Task DeleteGoal(Guid Id);

        public System.Threading.Tasks.Task UpdateGoal(Goal goal);
    }
}
