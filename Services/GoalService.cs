
using ExamenInnovation.Models;
using ExamenInnovation.RestApi;

namespace ExamenInnovation.Services
{
    public class GoalService : IGloalService
    {
        private readonly IRestApi _restApi;
        public GoalService( IRestApi restApi) { 
            _restApi = restApi;
        }

        public async System.Threading.Tasks.Task AddGoal(Goal goal)
        {
            try
            {
                await _restApi.AddGoal(goal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async System.Threading.Tasks.Task DeleteGoal(Guid Id)
        {
            try
            {
                await _restApi.DeleteGoal(Id);
            }
            catch(Exception ex) { 
                throw ex;
            }
        }

        public async Task<List<Goal>> GetAll()
        {
            try
            {
                var goals = await _restApi.GetAll();
                return goals;
            }
            catch(Exception ex) {
                throw ex;
            }
        }

        public async Task<Goal> GetById(Guid Id)
        {
            try
            {
                return await _restApi.GetById(Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async System.Threading.Tasks.Task UpdateGoal(Goal goal)
        {
            try
            {
                await _restApi.UpdateGoal(goal);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
