using GolfScore.Models;
using GolfScore.Models.Request;

namespace GolfScore.Services.Interfaces
{
    public interface IMatchService
    {
        Match CreateMatch(CreateMatchRequest request);
    }
}
