using TWJobs.Core.Models;

namespace TWJobs.Api.Jobs.Services
{
    public interface IJobService
    {
        ICollection<Job> FindAll();
        Job FindById(int id);
        Job Create(Job job);
        Job UpdateById(int id, Job job);
        void DeleteById(int id);
    }
}
