using GolfScore.Models;
using GolfScore.Models.Request;

namespace GolfScore.Services.Interfaces
{
    public interface IPlayerService
    {
        Player GetPlayer(string externalIdentifier, string authCode);
        void DeletePlayer(string externalIdentifier, string authCode);
        Player CreatePlayer(CreatePlayerRequest request);
    }
}
