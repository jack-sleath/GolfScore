using GolfScore.Models;
using GolfScore.Repositories.Interfaces;
using Microsoft.Azure.Cosmos;

namespace GolfScore.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly CosmosClient _cosmosClient;
        private Container _container;
        public CourseRepository(CosmosClient cosmosClient)
        {
            _cosmosClient = cosmosClient;
            _container = _cosmosClient.GetDatabase("golf-score").GetContainer("golf-score");
        }

        public async Task<List<Course>> GetCourses()
        {
            return _container.GetItemLinqQueryable<Course>().Where(x => x.Type == typeof(Course).Name).ToList();
        }

        public async Task<bool> UpsertAsync(Course course)
        {
            var result = await _container.UpsertItemAsync(course);

            return result.StatusCode == System.Net.HttpStatusCode.OK;
        }
    }
}
