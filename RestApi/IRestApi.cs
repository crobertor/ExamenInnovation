using ExamenInnovation.Models;
using Refit;
using Task = ExamenInnovation.Models.Task;

namespace ExamenInnovation.RestApi
{
    public interface IRestApi
    {
        [Post("/api/Goal")]
        public System.Threading.Tasks.Task AddGoal([Body] Goal goal);

        [Get("/api/Goal")]
        public Task<List<Goal>> GetAll();

        [Get("/api/Goal/{Id}")]
        public Task<Goal> GetById(Guid Id);

        [Delete("/api/Goal/{Id}")]
        public System.Threading.Tasks.Task DeleteGoal(Guid Id);

        [Put("/api/Goal")]
        public System.Threading.Tasks.Task UpdateGoal([Body] Goal goal);

        [Get("/api/Task/GetAll/{Id}")]
        public Task<List<Models.Task>> GetAllTaskByGoalId(Guid Id);

        [Post("/api/Task")]
        public System.Threading.Tasks.Task AddTask([Body] Models.Task task);

        [Delete("/api/Task/DeleteAll")]
        public System.Threading.Tasks.Task DeleteAllTask([Body] List<Guid> Id);


        [Post("/api/Task/CompletTask")]
        public System.Threading.Tasks.Task CompletTask([Body] List<Guid> Id);

        [Put("/api/Task")]
        public System.Threading.Tasks.Task UpdateTask([Body] Task task);

    }
}
