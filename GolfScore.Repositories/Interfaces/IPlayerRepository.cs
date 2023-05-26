using GolfScore.Models;

namespace GolfScore.Repositories.Interfaces
{
    public interface IPlayerRepository
    {
        Player GetPlayer(string uniqueIdentifier);
        Player GetPlayer(Guid playerId);
        Player SavePlayer(Player player);
        bool IsExistingUniqueIdentifier(string uniqueIdentifier);
    }
}
