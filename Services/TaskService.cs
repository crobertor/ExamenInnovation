
using ExamenInnovation.RestApi;

namespace ExamenInnovation.Services
{
    public class TaskService : ITaskService
    {
        private readonly IRestApi _restApi;
        public TaskService(IRestApi restApi)
        {
            _restApi = restApi;
        }

        public async System.Threading.Tasks.Task AddTask(Models.Task task)
        {
            try
            {
                await _restApi.AddTask(task);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteAllTask(List<Guid> Ids)
        {
            try
            {
                await _restApi.DeleteAllTask(Ids);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task CompleteTask(List<Guid> Ids)
        {
            try
            {
                await _restApi.CompletTask(Ids);
            }
            catch (Exception ex) { 
            
            throw ex;
            }
        }

        public async Task<List<Models.Task>> GetAllTask(Guid Id)
        {
            try
            {
                var tasks = await _restApi.GetAllTaskByGoalId(Id);
                return tasks;
            }
            catch (Exception ex)
            {

                throw ex;

            }
        }

        public async Task UpdateTask(Models.Task task)
        {
            try
            {
                 await _restApi.UpdateTask(task);
            }
            catch (Exception ex)
            {

                throw ex;

            }
        }
    }
}
