using GolfScore.Models;

namespace GolfScore.Repositories.Interfaces
{
    public interface ICourseRepository
    {
        Task<bool> UpsertAsync(Course course);
    }
}
