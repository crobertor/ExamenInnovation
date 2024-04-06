namespace ExamenInnovation.Services
{
    public interface ITaskService
    {
        public Task<List<Models.Task>> GetAllTask(Guid Id);

        public Task AddTask(Models.Task task);

        public Task DeleteAllTask(List<Guid> Ids);

        public Task CompleteTask(List<Guid> Ids);

        public Task UpdateTask(Models.Task task);
    }
}
